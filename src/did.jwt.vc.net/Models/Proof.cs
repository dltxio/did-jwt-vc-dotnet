using System;

namespace did.jwt.vc.net.Models
{
    public class Proof
    {
        [Newtonsoft.Json.JsonProperty("type", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Type { get; set; }

        [Newtonsoft.Json.JsonProperty("jwt", NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string JWT { get; set; }

        public Proof()
        {
            Type = "JtwProof2020";
        }
    }
}
