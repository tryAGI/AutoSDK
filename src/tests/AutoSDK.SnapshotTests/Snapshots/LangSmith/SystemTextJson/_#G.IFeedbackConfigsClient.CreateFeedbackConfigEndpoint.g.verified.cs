//HintName: G.IFeedbackConfigsClient.CreateFeedbackConfigEndpoint.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackConfigsClient
    {
        /// <summary>
        /// Create Feedback Config Endpoint
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackConfigSchema> CreateFeedbackConfigEndpointAsync(
            global::G.CreateFeedbackConfigSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback Config Endpoint
        /// </summary>
        /// <param name="feedbackKey"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="isLowerScoreBetter">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackConfigSchema> CreateFeedbackConfigEndpointAsync(
            string feedbackKey,
            global::G.FeedbackConfig feedbackConfig,
            bool? isLowerScoreBetter = false,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}