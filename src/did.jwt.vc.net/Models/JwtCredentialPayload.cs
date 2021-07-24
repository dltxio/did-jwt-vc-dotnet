using System;
using System.Collections.Generic;

namespace did.jwt.vc.net.Models
{
    public class JwtCredentialPayload
    {
        [Newtonsoft.Json.JsonProperty("vc")]
        public VC VerifiableCredential { get; set; }

        [Newtonsoft.Json.JsonProperty("sub")]
        public String Subject { get; set; }

        [Newtonsoft.Json.JsonProperty("nbf")]
        public UInt64 Nonce { get; set;}

        public JwtCredentialPayload()
        {
            Subject = "did:ethr";
        }
    }
}
