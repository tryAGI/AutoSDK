//HintName: G.IUsersClient.Get.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Get user info<br/>
        /// Get info about a specific Label Studio user, based on the user ID.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseUser> GetAsync(
            int id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}