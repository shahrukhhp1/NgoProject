using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspnetIdentityTest.Areas.Corporate.Models;
using AspnetIdentityTest.Data;
using AspnetIdentityTest.Data.Entity;
using AspnetIdentityTest.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspnetIdentityTest.Areas.Corporate.Controllers
{
    [Area("Corporate")]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        //protected UserManager<ApplicationUser> UserManager { get; set; }
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> CreateGrantForm(int sid)
        {
            GrantFormVM ret = new GrantFormVM();
            if (sid > 0)
            {
                var userId = User.GetIdentity();
                if (!string.IsNullOrEmpty(userId))
                {
                    var user = await _context.ApplicationUser.Where(x => x.Id.Equals(userId)).FirstOrDefaultAsync();
                    var company = await _context.Corporates.Where(x => x.Id.Equals(user.CorporateId.Value)).FirstOrDefaultAsync();
                    if (company != null)
                    {
                        var survey = await _context.Surveys.Include(x=>x.SurveyQuestions)
                            .Where(x => x.Id.Equals(sid) && x.CorporateId.Equals(company.Id))
                            .FirstOrDefaultAsync();
                        if (survey != null)
                        {
                            ret.Title = survey.Title;
                            ret.SurveyId = survey.Id;
                            foreach (var quest in survey.SurveyQuestions)
                            {
                                var options = await _context.SurveyQuestionOptions.Where(x => x.SurveyQuestionId.Equals(quest.Id))
                                    .Select(x => x.Text).ToListAsync();
                                ret.Questions.Add(new GrantQuestionVM()
                                {
                                    Id = quest.Id,
                                    Text = quest.Text,
                                    Type = quest.Type,
                                    Options = options
                                });
                            }
                        }
                    }
                }
            }
            return View(ret);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUpdateGrantForm(GrantFormVM data)
        {
            var a = data;
            var userId = User.GetIdentity();
            if (!string.IsNullOrEmpty(userId))
            {
                var user = await _context.ApplicationUser.Where(x => x.Id.Equals(userId)).FirstOrDefaultAsync();
                //.Where(x => x.Id.Equals(userId)).FirstOrDefault();
                if (user != null && user.CorporateId.HasValue)
                {
                    var company = await _context.Corporates.Where(x => x.Id.Equals(user.CorporateId.Value)).FirstOrDefaultAsync();
                    if (company != null)
                    {
                        if (data.SurveyId == 0)
                        {
                            var survQuestions = new List<SurveyQuestion>();
                            foreach (var quest in data.Questions)
                            {
                                var survQuestOpts = new List<SurveyQuestionOption>();

                                foreach (var opt in quest.Options)
                                {
                                    survQuestOpts.Add(new SurveyQuestionOption()
                                    {
                                        Text = opt
                                    });
                                }

                                survQuestions.Add(new SurveyQuestion()
                                {
                                    Type = quest.Type,
                                    Text = quest.Text,
                                    SurveyQuestionOptions = survQuestOpts
                                });
                            }

                            Survey newSurv = new Survey()
                            {
                                Title = data.Title,
                                CorporateId = company.Id,
                                CreatedOn = DateTime.Now,
                                CreatedBy = user.UserName,
                                Month = DateTime.Now.Month,
                                Year = DateTime.Now.Year,
                                SurveyQuestions = survQuestions
                            };

                            await _context.AddAsync(newSurv);
                            await _context.SaveChangesAsync();
                        }
                        else {
                            var surveyQuesions = await _context.SurveyQuestions.Where(x => x.Id.Equals(data.SurveyId)).FirstOrDefaultAsync();
                            //remove all and then add
                        }
                    }
                }
            }

            return View();
        }
    }
}