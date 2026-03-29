//HintName: G.ISentimentAnalysisJobsClient.SubmitSentimentAnalysisJob.g.cs
#nullable enable

namespace G
{
    public partial interface ISentimentAnalysisJobsClient
    {
        /// <summary>
        /// Submit Sentiment Analysis Job<br/>
        /// Starts an asynchronous sentiment analysis job. Input can be plain text, a JSON transcript, or reference a completed transcription job.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SentimentAnalysisJob> SubmitSentimentAnalysisJobAsync(

            global::G.SubmitSentimentAnalysisJobRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit Sentiment Analysis Job<br/>
        /// Starts an asynchronous sentiment analysis job. Input can be plain text, a JSON transcript, or reference a completed transcription job.
        /// </summary>
        /// <param name="json">
        /// Rev.ai Transcript
        /// </param>
        /// <param name="text">
        /// Plain text to analyze for sentiment
        /// </param>
        /// <param name="metadata">
        /// Optional metadata
        /// </param>
        /// <param name="callbackUrl">
        /// Optional callback URL
        /// </param>
        /// <param name="language">
        /// Language of the input text
        /// </param>
        /// <param name="deleteAfterSeconds">
        /// Auto-delete job after this many seconds
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SentimentAnalysisJob> SubmitSentimentAnalysisJobAsync(
            global::G.Transcript? json = default,
            string? text = default,
            string? metadata = default,
            string? callbackUrl = default,
            string? language = default,
            int? deleteAfterSeconds = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}