using Microsoft.AspNetCore.Identity;

namespace packt.API.Data
{
    public class ApiUser : IdentityUser
    {
        public string firstName {  get; set; }
        public string lastName { get; set; }
    }
}
