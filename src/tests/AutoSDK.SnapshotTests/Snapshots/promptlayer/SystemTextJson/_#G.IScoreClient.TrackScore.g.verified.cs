//HintName: G.IScoreClient.TrackScore.g.cs
#nullable enable

namespace G
{
    public partial interface IScoreClient
    {
        /// <summary>
        /// Track Score
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackScoreResponse> TrackScoreAsync(

            global::G.TrackScoreRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Track Score
        /// </summary>
        /// <param name="requestId">
        /// The `request_id` from tracking a request.
        /// </param>
        /// <param name="score">
        /// The score you would like to give to this request (0 - 100).
        /// </param>
        /// <param name="name">
        /// A name for this request score. If not provided, the score will be tracked as `default`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TrackScoreResponse> TrackScoreAsync(
            int requestId,
            int score,
            string? name = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}