//HintName: G.IFeedbackClient.DeleteFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Delete Feedback<br/>
        /// Delete a feedback.
        /// </summary>
        /// <param name="feedbackId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeleteFeedbackAsync(
            global::System.Guid feedbackId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}