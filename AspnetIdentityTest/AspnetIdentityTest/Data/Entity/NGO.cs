using AspnetIdentityTest.Data.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetIdentityTest.Data.Entity
{
    public class NGO : BaseEntity
    {
        public NGO()
        {
            this.Users = new HashSet<ApplicationUser>();
            this.NGOCities = new HashSet<NGOCity>();
            this.NGOProvinces = new HashSet<NGOProvince>();
            this.NGOThemes = new HashSet<NGOTheme>();
        }

        [Column(TypeName = "varchar(250)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string FounderName { get; set; }
        
        public int YearFound { get; set; }
        public string Mission { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Phone { get; set; }
        //public NGOTheme Theme { get; set; }

        public string OfficeAddress { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Twitter { get; set; }
        public string Email { get; set; }
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



        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<NGOCity> NGOCities { get; set; }
        public virtual ICollection<NGOProvince> NGOProvinces { get; set; }
        public virtual ICollection<NGOTheme> NGOThemes { get; set; }
    }
}
