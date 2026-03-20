//HintName: G.ILoginClient.Rsa.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Get RSA Public Key<br/>
        /// Retrieves RSA public information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RSAWriteKeyInfo> RsaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}