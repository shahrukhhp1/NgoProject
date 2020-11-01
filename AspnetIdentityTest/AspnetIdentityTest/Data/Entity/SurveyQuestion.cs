using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class SurveyQuestion : BaseEntity
    {
        public SurveyQuestion()
        {
            this.SurveyQuestionOptions = new HashSet<SurveyQuestionOption>();
        }

        public string Text { get; set; }
        public string Type { get; set; }

        public long? SurveyId { get; set; }
        public virtual Survey Survey { get; set; }

        public ICollection<SurveyQuestionOption> SurveyQuestionOptions { get; set; }
    }
}
