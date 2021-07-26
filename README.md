# did-jwt-vc-dotnet

Create and verify W3C Verifiable Credentials and Presentations in JWT format

## Installation

```
dotnet add package did.jwt.vc.dotnet
```

## Usage

### Creating JWTs

```csharp
IIsuer issuer = new EthDID("0xf1232f840f3ad7d23fcdaa84d6c66dac24efb198", "d8b595680851765f38ea5405129244ba3cbad84467d190859f4c8b20c1ff6c75";
```

The `Issuer` object must contain a `did` attribute, an `alg` property that is used in the JWT header and a `signer` function to generate the signature.

#### Creating a Verifiable Credential

Specify a `payload` matching the `CredentialPayload` or `JwtCredentialPayload` interfaces. Create a JWT by signing it with the previously configured `issuer` using the `createVerifiableCredentialJwt` function:
