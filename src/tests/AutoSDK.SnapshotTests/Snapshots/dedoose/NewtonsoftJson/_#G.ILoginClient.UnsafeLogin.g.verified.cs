//HintName: G.ILoginClient.UnsafeLogin.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Unsafe Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(
            global::G.UnsafeLoginRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Unsafe Login to Dedoose API<br/>
        /// Authenticates a user and returns an access token.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UnsafeLoginAsync(
            string username,
            string password,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}