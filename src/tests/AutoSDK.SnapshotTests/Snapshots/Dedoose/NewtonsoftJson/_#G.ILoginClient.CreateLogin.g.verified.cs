//HintName: G.ILoginClient.CreateLogin.g.cs
#nullable enable

namespace G
{
    public partial interface ILoginClient
    {
        /// <summary>
        /// Login to Dedoose API use encrypted password.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateLoginAsync(
            global::G.LoginRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Login to Dedoose API use encrypted password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="rsaEncryptedPassword"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> CreateLoginAsync(
            string? username = default,
            string? rsaEncryptedPassword = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}