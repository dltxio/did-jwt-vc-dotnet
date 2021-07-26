using System;
using System.Threading.Tasks;

namespace did.jwt.vc.net.Models
{
    public interface IIssuer
    {
        string Identifier { get; }

        Task CreateVerifiableCredentialJwt();
    }
}
