//HintName: G.IRatingsClient.DeleteRating.g.cs
#nullable enable

namespace G
{
    public partial interface IRatingsClient
    {
        /// <summary>
        /// Delete a rating<br/>
        /// Delete a specific rating of agent chat message
        /// </summary>
        /// <param name="agentId"></param>
        /// <param name="chatId"></param>
        /// <param name="ratingId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteRatingResponse> DeleteRatingAsync(
            string agentId,
            string chatId,
            string ratingId,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}