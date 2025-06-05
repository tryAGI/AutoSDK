//HintName: G.IApi.SubmitFeedbackV1FeedbackPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Submit Feedback<br/>
        /// Submit feedback
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitFeedbackV1FeedbackPostAsync(
            global::G.FeedbackIn request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit Feedback<br/>
        /// Submit feedback
        /// </summary>
        /// <param name="xiApiKey"></param>
        /// <param name="message">
        /// The message you'd like to send to deepinfra team
        /// </param>
        /// <param name="contactEmail">
        /// Optional contact email to reach you back
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> SubmitFeedbackV1FeedbackPostAsync(
            string message,
            string? xiApiKey = default,
            string? contactEmail = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}