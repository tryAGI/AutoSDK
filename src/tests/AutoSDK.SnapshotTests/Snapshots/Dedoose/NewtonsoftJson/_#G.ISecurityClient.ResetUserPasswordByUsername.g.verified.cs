//HintName: G.ISecurityClient.ResetUserPasswordByUsername.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// ResetUserPasswordByUsername<br/>
        /// ResetUserPasswordByUsername
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<bool> ResetUserPasswordByUsernameAsync(
            global::G.ResetUserPasswordByUsernameRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ResetUserPasswordByUsername<br/>
        /// ResetUserPasswordByUsername
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<bool> ResetUserPasswordByUsernameAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}