using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Areas.Corporate.Models
{
    public class GrantFormVM
    {
        public GrantFormVM()
        {
            this.Questions = new List<GrantQuestionVM>();
        }

        public long SurveyId { get; set; }
        public string Title { get; set; }
        public bool IsLocked { get; set; }

        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }

        public List<GrantQuestionVM> Questions { get; set; }
    }
}
