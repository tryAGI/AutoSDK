//HintName: G.IFeedbackClient.ReadFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Read Feedback<br/>
        /// Get a specific feedback.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="includeUserNames"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackSchema> ReadFeedbackAsync(
            global::System.Guid feedbackId,
            bool? includeUserNames = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}