using System;
using System.Collections.Generic;
using System.Text;
using AspnetIdentityTest.Data.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspnetIdentityTest.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Corporate> Corporates { get; set; }
        public DbSet<NGO> NGOs { get; set; }

        public DbSet<Survey> Surveys { get; set; }
        public DbSet<SurveyQuestion> SurveyQuestions { get; set; }
        public DbSet<SurveyQuestionOption> SurveyQuestionOptions { get; set; }
        public DbSet<SurveyAnswer> SurveyAnswers { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<NGOCity> NGOCitys { get; set; }
        public DbSet<NGOProvince> NGOProvinces { get; set; }
        public DbSet<NGOTheme> NGOThemes { get; set; }
        public DbSet<Theme> Themes { get; set; }

    }
}
