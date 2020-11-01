using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class SurveyQuestionOption : BaseEntity
    {
        public string Text { get; set; }
        public long? SurveyQuestionId { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }
    }
}
