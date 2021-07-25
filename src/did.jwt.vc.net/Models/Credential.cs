using System;
namespace did.jwt.vc.net.Models
{
    public class Credential
    {
        public Credential()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
