//HintName: G.IAdminClient.UpdateUserInfoAsAdmin.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// UpdateUserInfo<br/>
        /// UpdateUserInfo
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserInfoAsAdminAsync(
            global::G.UpdateUserInfoRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// UpdateUserInfo<br/>
        /// UpdateUserInfo
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> UpdateUserInfoAsAdminAsync(
            global::System.Guid userId,
            string username,
            string email,
            string phone,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}