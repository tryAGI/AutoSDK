//HintName: G.IAdminClient.AdminUpdateUserInfo.g.cs
#nullable enable

namespace G
{
    public partial interface IAdminClient
    {
        /// <summary>
        /// UpdateUserInfo.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="userId"></param>
        /// <param name="username"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.AdminUpdateUserInfoResponse> AdminUpdateUserInfoAsync(
            string? token = default,
            global::System.Guid? userId = default,
            string? username = default,
            string? email = default,
            string? phone = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}