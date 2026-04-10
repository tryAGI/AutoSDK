//HintName: G.IMetadataClient.TrackMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IMetadataClient
    {
        /// <summary>
        /// Track Metadata
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackMetadataResponse> TrackMetadataAsync(

            global::G.TrackMetadataRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Metadata
        /// </summary>
        /// <param name="requestId">
        /// The unique identifier for the request to which the metadata is associated.
        /// </param>
        /// <param name="metadata">
        /// A dictionary of metadata items to associate with the request. Can include session_ids, user_ids, location, etc.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackMetadataResponse> TrackMetadataAsync(
            int requestId,
            object metadata,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}