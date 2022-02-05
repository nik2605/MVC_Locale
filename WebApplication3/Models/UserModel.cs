using System.ComponentModel.DataAnnotations;
using WebApplication3.Resources;

namespace WebApplication3.Models
{
    public class UserModel
    {
        [Display(ResourceType = typeof(Webapp), Name = "UserModel_FName_User_first_name")]
       
        public string FName { get; set; }
        public string LName { get; set; }

        public Address Address { get; set; }

        public string GetFullName()
        {
            return FName + " " + this.LName;
        }
    }

    public class Address
    {
        [Display(ResourceType = typeof(Webapp), Name = "Address_Street_Address")]
        public string Street { get; set; }
        [Display(ResourceType = typeof(Webapp), Name = "Province")]
        public string Province { get; set; }
    }
}