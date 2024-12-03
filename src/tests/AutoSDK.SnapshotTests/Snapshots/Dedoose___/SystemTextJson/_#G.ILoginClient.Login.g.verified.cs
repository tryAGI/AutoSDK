//HintName: G.ILoginClient.Login.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> LoginAsync(
            global::G.LoginRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPassword"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> LoginAsync(
            string username,
            string rsaEncryptedPassword,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}