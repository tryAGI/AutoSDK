//HintName: G.IUsersClient.Delete.g.cs
#nullable enable

namespace G
{
    public partial interface IUsersClient
    {
        /// <summary>
        /// Delete user<br/>
        /// Delete a specific Label Studio user. Only available in community edition.<br/>
        /// &lt;Warning&gt;Use caution when deleting a user, as this can cause issues such as breaking the "Annotated by" filter or leaving orphaned records.&lt;/Warning&gt;
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteAsync(
            int id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}