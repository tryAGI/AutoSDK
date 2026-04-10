//HintName: G.IStepsClient.ModifyFeedbackForStep.g.cs
#nullable enable

namespace G
{
    public partial interface IStepsClient
    {
        /// <summary>
        /// Modify Feedback For Step<br/>
        /// Modify feedback for a given step.
        /// </summary>
        /// <param name="stepId">
        /// The ID of the step in the format 'step-&lt;uuid4&gt;'
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Step> ModifyFeedbackForStepAsync(
            string stepId,

            global::G.ModifyFeedbackRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Modify Feedback For Step<br/>
        /// Modify feedback for a given step.
        /// </summary>
        /// <param name="stepId">
        /// The ID of the step in the format 'step-&lt;uuid4&gt;'
        /// </param>
        /// <param name="feedback">
        /// Whether this feedback is positive or negative
        /// </param>
        /// <param name="tags">
        /// Feedback tags to add to the step
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Step> ModifyFeedbackForStepAsync(
            string stepId,
            global::G.FeedbackType? feedback = default,
            global::System.Collections.Generic.IList<string>? tags = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}