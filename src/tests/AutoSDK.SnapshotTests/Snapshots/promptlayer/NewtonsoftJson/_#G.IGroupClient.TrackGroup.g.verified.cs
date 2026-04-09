//HintName: G.IGroupClient.TrackGroup.g.cs
#nullable enable

namespace G
{
    public partial interface IGroupClient
    {
        /// <summary>
        /// Track Group
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackGroupResponse> TrackGroupAsync(

            global::G.TrackGroupRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Group
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier for the request.
        /// </param>
        /// <param name="groupId">
        /// The unique identifier for the group to be associated with the request.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackGroupResponse> TrackGroupAsync(
            int requestId,
            int groupId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}