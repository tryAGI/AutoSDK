//HintName: G.IAuthClient.ConfirmSsoUserEmail.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmSsoUserEmailAsync(
            global::G.SSOConfirmEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Confirm Sso User Email<br/>
        /// Confirm the email of an SSO user.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ConfirmSsoUserEmailAsync(
            string token,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}