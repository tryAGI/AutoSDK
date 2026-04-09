//HintName: G.IUsersClient.DeleteUser.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete a user by ID<br/>
        /// Delete an existing user by their unique GlobalID.
        /// </summary>
        /// <param name="userId">
        /// The GlobalID of the user (e.g. 'VXNlcjox').
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteUserAsync(
            string userId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}