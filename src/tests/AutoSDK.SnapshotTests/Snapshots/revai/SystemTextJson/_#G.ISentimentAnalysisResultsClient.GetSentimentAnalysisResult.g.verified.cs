//HintName: G.ISentimentAnalysisResultsClient.GetSentimentAnalysisResult.g.cs
#nullable enable

namespace G
{
    public partial interface ISentimentAnalysisResultsClient
    {
        /// <summary>
        /// Get Sentiment Analysis Result<br/>
        /// Returns the sentiment analysis result for a completed job.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SentimentAnalysisResult> GetSentimentAnalysisResultAsync(
            string id,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}