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

        public async Task<IActionResult> ListGrantForm()
        {
            List<GrantFormVM> ret = new List<GrantFormVM>();

            var userId = User.GetIdentity();
            if (!string.IsNullOrEmpty(userId))
            {
                var user = await _context.ApplicationUser.Where(x => x.Id.Equals(userId)).FirstOrDefaultAsync();
                if (user != null && user.CorporateId.HasValue)
                {
                    ret = await _context.Surveys.Where(x => x.CorporateId.Equals(user.CorporateId.Value))
                        .Select(x=> new GrantFormVM {
                            CreatedBy = x.CreatedBy,
                            CreatedOn =x.CreatedOn,
                            IsLocked = x.IsLocked,
                            Month  = x.Month,
                            SurveyId = x.Id,
                            Title = x.Title,
                            Year = x.Year
                        }).ToListAsync();
                }
            }
            return View(ret);
        }


        public async Task<IActionResult> CreateGrantForm(int sid)
        {
            GrantFormVM ret = new GrantFormVM();
            ret = await GetGrantForm(sid);
            return View(ret);
        }

        public async Task<IActionResult> ViewGrantForm(int sid)
        {
            GrantFormVM ret = new GrantFormVM();
            ret = await GetGrantForm(sid);
            return View(ret);
        }

        private async Task<GrantFormVM> GetGrantForm(int sid)
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
                        var survey = await _context.Surveys.Include(x => x.SurveyQuestions)
                            .Where(x => x.Id.Equals(sid) && x.CorporateId.Equals(company.Id))
                            .FirstOrDefaultAsync();
                        if (survey != null)
                        {
                            ret.Title = survey.Title;
                            ret.SurveyId = survey.Id;
                            ret.IsLocked = survey.IsLocked;
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
            return ret;
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
                                if (quest.Type.ToLower() != "open")
                                {
                                    foreach (var opt in quest.Options)
                                    {
                                        survQuestOpts.Add(new SurveyQuestionOption()
                                        {
                                            Text = opt
                                        });
                                    }
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
                            return RedirectToAction("ViewGrantForm", "Home", new { area = "Corporate", sid = newSurv.Id });
                        }
                        else {
                            var surveyQuesions = await _context.SurveyQuestions.Where(x => x.SurveyId.Equals(data.SurveyId)).ToListAsync();
                            //remove all and then add
                            foreach (var quest in surveyQuesions)
                            {
                                var questOptions = await _context.SurveyQuestionOptions.Where(x => x.SurveyQuestionId.Equals(quest.Id)).ToListAsync();
                                _context.SurveyQuestionOptions.RemoveRange(questOptions);
                            }
                            _context.SurveyQuestions.RemoveRange(surveyQuesions);
                            await _context.SaveChangesAsync();

                            foreach (var quest in data.Questions)
                            {
                                var survQuestOpts = new List<SurveyQuestionOption>();

                                if (quest.Type.ToLower() != "open")
                                {
                                    foreach (var opt in quest.Options)
                                    {
                                        survQuestOpts.Add(new SurveyQuestionOption()
                                        {
                                            Text = opt
                                        });
                                    }
                                }
                                await _context.SurveyQuestions.AddAsync(new SurveyQuestion()
                                {
                                    Type = quest.Type,
                                    Text = quest.Text,
                                    SurveyQuestionOptions = survQuestOpts,
                                    SurveyId = data.SurveyId,
                                });
                            }
                            await _context.SaveChangesAsync();
                            return RedirectToAction("ViewGrantForm", "Home", new { area = "Corporate", sid = data.SurveyId });
                        }
                    }
                }
            }
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> FinalizeGrantForm(GrantFormVM data)
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
                        var survey = await _context.Surveys.Where(x => x.Id.Equals(data.SurveyId)).FirstOrDefaultAsync();
                        if(survey != null)
                        {
                            survey.IsLocked = true;
                            _context.Surveys.Update(survey);
                            await _context.SaveChangesAsync();
                        }
                    }
                }
            }
            return View();
        }
    }
}