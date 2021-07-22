namespace did.jwt.vc.net.Models
{
    public class Evidence
    {
        public Evidence()
        {
        }

        public string Type { get; set; }
        public string Verifier { get; set; }
        public string EvidenceDocument { get; set; }
        public string DocumentPresence { get; set; }
    }
}