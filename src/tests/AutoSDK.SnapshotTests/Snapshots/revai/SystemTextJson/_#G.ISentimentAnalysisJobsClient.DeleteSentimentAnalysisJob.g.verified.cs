//HintName: G.ISentimentAnalysisJobsClient.DeleteSentimentAnalysisJob.g.cs
#nullable enable

namespace G
{
    public partial interface ISentimentAnalysisJobsClient
    {
        /// <summary>
        /// Delete Sentiment Analysis Job<br/>
        /// Deletes a sentiment analysis job and all associated data.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteSentimentAnalysisJobAsync(
            string id,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}