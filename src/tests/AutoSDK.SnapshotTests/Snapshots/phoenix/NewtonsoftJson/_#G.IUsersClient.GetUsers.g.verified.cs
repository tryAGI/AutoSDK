//HintName: G.IUsersClient.GetUsers.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// List all users<br/>
        /// Retrieve a paginated list of all users in the system.
        /// </summary>
        /// <param name="cursor">
        /// Cursor for pagination (base64-encoded user ID)
        /// </param>
        /// <param name="limit">
        /// The max number of users to return at a time.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetUsersResponseBody> GetUsersAsync(
            string? cursor = default,
            int? limit = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}