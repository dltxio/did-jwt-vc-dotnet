using System;
using System.Threading.Tasks;

namespace did.jwt.vc.net.Models
{
    public interface IIsuer
    {
        string Identifier { get; }

        Task CreateVerifiableCredentialJwt();
    }
}
