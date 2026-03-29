//HintName: G.IFeedbackClient.UpdateFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Updates existing feedback<br/>
        /// This endpoint allows users to update existing feedback.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponse> UpdateFeedbackAsync(
            global::System.Guid id,

            global::G.FeedbackUpdateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates existing feedback<br/>
        /// This endpoint allows users to update existing feedback.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value">
        /// Feedback value, an integer between -10 and 10.
        /// </param>
        /// <param name="weight">
        /// Weight of the feedback, a float between 0 and 1. Default is 1.0.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="metadata">
        /// Additional metadata for the feedback.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackResponse> UpdateFeedbackAsync(
            global::System.Guid id,
            int value,
            float? weight = default,
            object? metadata = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}