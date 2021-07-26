using System;

namespace did.jwt.vc.net.Models
{
    public class Evidence
    {
        public Evidence()
        {
        }

        public string Key { get; set; }
        public string Type { get; set; }
        public string Signature { get; set; }
        public string Verifier { get; set; }
        public string EvidenceDocument { get; set; }
        public string DocumentPresence { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}