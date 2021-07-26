using System;

namespace did.jwt.vc.net.Models
{
    public class Credential
    {
        public Credential()
        {
        }


        public string Key { get; set; }
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
