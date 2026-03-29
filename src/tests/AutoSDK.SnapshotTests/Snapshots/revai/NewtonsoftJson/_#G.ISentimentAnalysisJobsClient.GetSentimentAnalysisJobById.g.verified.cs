//HintName: G.ISentimentAnalysisJobsClient.GetSentimentAnalysisJobById.g.cs
#nullable enable

namespace G
{
    public partial interface ISentimentAnalysisJobsClient
    {
        /// <summary>
        /// Get Sentiment Analysis Job By Id<br/>
        /// Returns information about a sentiment analysis job
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SentimentAnalysisJob> GetSentimentAnalysisJobByIdAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}