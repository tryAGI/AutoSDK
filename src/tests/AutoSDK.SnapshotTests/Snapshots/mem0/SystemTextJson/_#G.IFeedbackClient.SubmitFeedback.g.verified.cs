//HintName: G.IFeedbackClient.SubmitFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Submit feedback for a memory.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubmitFeedbackResponse> SubmitFeedbackAsync(

            global::G.SubmitFeedbackRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit feedback for a memory.
        /// </summary>
        /// <param name="memoryId">
        /// ID of the memory to provide feedback for
        /// </param>
        /// <param name="feedback">
        /// Type of feedback
        /// </param>
        /// <param name="feedbackReason">
        /// Reason for the feedback
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SubmitFeedbackResponse> SubmitFeedbackAsync(
            string memoryId,
            global::G.SubmitFeedbackRequestFeedback? feedback = default,
            string? feedbackReason = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}