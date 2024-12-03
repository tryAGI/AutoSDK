//HintName: G.ISecurityClient.ResetUserPasswordByEmail.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// ResetUserPasswordByEmail<br/>
        /// ResetUserPasswordByEmail
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ResetUserPasswordByEmailAsync(
            global::G.ResetUserPasswordByEmailRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ResetUserPasswordByEmail<br/>
        /// ResetUserPasswordByEmail
        /// </summary>
        /// <param name="userEmail"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> ResetUserPasswordByEmailAsync(
            string userEmail,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}