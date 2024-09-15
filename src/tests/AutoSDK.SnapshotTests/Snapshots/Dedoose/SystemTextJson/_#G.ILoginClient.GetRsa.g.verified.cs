//HintName: G.ILoginClient.GetRsa.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Returns RSA public information.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RSAWriteKeyInfo> GetRsaAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}