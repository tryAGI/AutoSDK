//HintName: G.IUsersClient.ModifyUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Modifies a user's role in the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> ModifyUserAsync(
            string userId,
            global::G.UserRoleUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a user's role in the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.User> ModifyUserAsync(
            string userId,
            global::G.UserRoleUpdateRequestRole role,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}