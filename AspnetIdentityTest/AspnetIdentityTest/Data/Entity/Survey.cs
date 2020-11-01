using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class Survey : BaseEntity
    {
        public Survey()
        {
            this.SurveyQuestions = new HashSet<SurveyQuestion>();
        }

        public string Title { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public bool IsLocked { get; set; } = false;

        public long? CorporateId { get; set; }
        public virtual Corporate Corporate { get; set; }

        public ICollection<SurveyQuestion> SurveyQuestions { get; set; }
    }
}
