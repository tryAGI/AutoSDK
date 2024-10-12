//HintName: G.ISecurityClient.SecurityImpersonateUser.g.cs
#nullable enable

namespace G
{
    public partial interface ISecurityClient
    {
        /// <summary>
        /// ImpersonateUser.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SecurityImpersonateUserAsync(
            string? token = default,
            string? username = default,
            string? email = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}