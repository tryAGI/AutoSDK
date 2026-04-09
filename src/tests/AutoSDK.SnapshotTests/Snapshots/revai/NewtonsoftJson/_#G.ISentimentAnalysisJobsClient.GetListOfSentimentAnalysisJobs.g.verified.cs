//HintName: G.ISentimentAnalysisJobsClient.GetListOfSentimentAnalysisJobs.g.cs
#nullable enable

namespace G
{
    public partial interface ISentimentAnalysisJobsClient
    {
        /// <summary>
        /// Get List of Sentiment Analysis Jobs<br/>
        /// Gets a list of sentiment analysis jobs submitted within the last 30 days.
        /// </summary>
        /// <param name="limit"></param>
        /// <param name="startingAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.SentimentAnalysisJob>> GetListOfSentimentAnalysisJobsAsync(
            int? limit = default,
            string? startingAfter = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}