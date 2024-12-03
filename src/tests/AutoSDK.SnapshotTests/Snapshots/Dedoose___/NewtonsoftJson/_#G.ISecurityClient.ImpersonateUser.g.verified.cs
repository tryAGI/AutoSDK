//HintName: G.ISecurityClient.ImpersonateUser.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// ImpersonateUser<br/>
        /// ImpersonateUser
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ImpersonateUserAsync(
            global::G.ImpersonateUserRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// ImpersonateUser<br/>
        /// ImpersonateUser
        /// </summary>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> ImpersonateUserAsync(
            string username,
            string email,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}