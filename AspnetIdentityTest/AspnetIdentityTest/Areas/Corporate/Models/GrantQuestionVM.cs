using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Areas.Corporate.Models
{
    public class GrantQuestionVM
    {
        public GrantQuestionVM()
        {
            this.Options = new List<string>();
        }

        public string Type { get; set; }
        public string Text { get; set; }
        public List<String> Options { get; set; }
    }
}
