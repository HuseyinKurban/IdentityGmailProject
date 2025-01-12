using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityGmailProject.EntityLayer.Concrete
{
    public class AppUser:IdentityUser<int>
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string ProfilImageUrl { get; set; }

        public string CoverImageUrl { get; set; }

        public string Job { get; set; }

        public string Detail { get; set; }

       
    }
}
