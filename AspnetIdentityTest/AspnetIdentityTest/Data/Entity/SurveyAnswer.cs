using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class SurveyAnswer : BaseEntity
    {
        public long? SurveyQuestionId { get; set; }
        public virtual SurveyQuestion SurveyQuestion { get; set; }

        public virtual NGO NGO { get;set;}
        public long? NGOId { get; set; }

        public string HTML { get; set; }

        public long? SurveyQuestionOptionId { get; set; }
        public virtual SurveyQuestionOption SurveyQuestionOption { get; set; }
    }
}
