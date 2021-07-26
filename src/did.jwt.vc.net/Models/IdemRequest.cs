using System;
using System.Collections.Generic;

namespace did.jwt.vc.net.Models
{
    public class IdemRequest
    {
        public IdemRequest()
        {
        }

        public Guid Id { get; set; }
        public string Type { get; set; }
        public string Issuer { get; set; }
        public DateTime IssuanceDate { get; set; }
        public List<Credential> Credential { get; set; }
        public List<Evidence> Evidences { get; set; }
    }
}
