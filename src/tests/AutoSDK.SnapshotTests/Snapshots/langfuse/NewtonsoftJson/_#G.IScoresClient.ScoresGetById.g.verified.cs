//HintName: G.IScoresClient.ScoresGetById.g.cs
#nullable enable

namespace G
{
    public partial interface IScoresClient
    {
        /// <summary>
        /// Get a score (supports both trace and session scores)
        /// </summary>
        /// <param name="scoreId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Score> ScoresGetByIdAsync(
            string scoreId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}