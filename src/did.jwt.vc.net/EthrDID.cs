using System;
using System.Threading.Tasks;
using Nethereum.Web3.Accounts;

namespace did.jwt.vc.net.Models
{
    public class EthrDID : IIssuer
    {
        public string Identifier { get; }

        public EthrDID(Account account)
        {
            Identifier = account.Address;
        }

        public EthrDID(String identifier)
        {
            Identifier = identifier;
        }

        public async Task CreateVerifiableCredentialJwt()
        {
        }
    }
}
