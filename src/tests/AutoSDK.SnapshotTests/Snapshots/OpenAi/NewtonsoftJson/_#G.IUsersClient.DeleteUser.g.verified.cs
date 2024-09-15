//HintName: G.IUsersClient.DeleteUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Deletes a user from the organization.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UserDeleteResponse> DeleteUserAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}