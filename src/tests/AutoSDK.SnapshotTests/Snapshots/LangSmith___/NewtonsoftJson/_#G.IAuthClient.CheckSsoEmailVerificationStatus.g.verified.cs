//HintName: G.IAuthClient.CheckSsoEmailVerificationStatus.g.cs
#nullable enable

namespace G
{
    public partial interface IAuthClient
    {
        /// <summary>
        /// Check Sso Email Verification Status<br/>
        /// Retrieve the email verification status of an SSO user.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SSOEmailVerificationStatusResponse> CheckSsoEmailVerificationStatusAsync(
            global::G.SSOEmailVerificationStatusRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Check Sso Email Verification Status<br/>
        /// Retrieve the email verification status of an SSO user.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="samlProviderId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SSOEmailVerificationStatusResponse> CheckSsoEmailVerificationStatusAsync(
            string email,
            global::System.Guid samlProviderId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}