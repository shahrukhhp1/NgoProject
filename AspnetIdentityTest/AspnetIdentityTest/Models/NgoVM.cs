using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Models
{
    public class NgoVM
    {
        public string Name { get; set; }

        public string FounderName { get; set; }

        public DateTime YearFound { get; set; }
        public string Mission { get; set; }

        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Mobile { get; set; }

        public string OfficeAddress { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
        public string Budget { get; set; }
        public string FinancialTransparency { get; set; } //attachment
        public string FBRCertificate { get; set; } //attachment
        public string PCFPCertificate { get; set; } //attachment
        public string HowToDonate { get; set; }
        public long NumberOfEmployees { get; set; }

        public string ContactPersonName { get; set; }
        public string ContactPersonTitle { get; set; }
        public string ContactPersonTelephoneNumber { get; set; }
        public string ContactPersonCellNumber { get; set; }
        public string ContactPersonEmail { get; set; }
        public string User { get; set; }
        public string Password { get; set; }

    }
}
