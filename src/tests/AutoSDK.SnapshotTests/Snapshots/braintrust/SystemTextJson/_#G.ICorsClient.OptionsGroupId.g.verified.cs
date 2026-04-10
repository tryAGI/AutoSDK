//HintName: G.ICorsClient.OptionsGroupId.g.cs
#nullable enable

namespace G
{
    public partial interface ICorsClient
    {
        /// <summary>
        /// Enable CORS (`/v1/group/{group_id}`)<br/>
        /// Enable CORS
        /// </summary>
        /// <param name="groupId">
        /// Group id
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task OptionsGroupIdAsync(
            global::System.Guid groupId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}