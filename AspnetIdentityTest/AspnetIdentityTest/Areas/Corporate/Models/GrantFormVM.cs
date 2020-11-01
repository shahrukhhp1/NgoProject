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
        public List<GrantQuestionVM> Questions { get; set; }
    }
}
