//HintName: G.IUsersClient.DeleteAdminUsersByUserId.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Remove a user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteAdminUsersByUserIdAsync(
            string userId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}