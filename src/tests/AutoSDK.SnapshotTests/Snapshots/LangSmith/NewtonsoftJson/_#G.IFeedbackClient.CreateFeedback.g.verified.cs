//HintName: G.IFeedbackClient.CreateFeedback.g.cs
#nullable enable

namespace G
{
    public partial interface IFeedbackClient
    {
        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackSchema> CreateFeedbackAsync(
            global::G.FeedbackCreateSchema request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Feedback<br/>
        /// Create a new feedback.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="modifiedAt"></param>
        /// <param name="key"></param>
        /// <param name="score"></param>
        /// <param name="value"></param>
        /// <param name="comment"></param>
        /// <param name="correction"></param>
        /// <param name="feedbackGroupId"></param>
        /// <param name="comparativeExperimentId"></param>
        /// <param name="runId"></param>
        /// <param name="sessionId"></param>
        /// <param name="id"></param>
        /// <param name="feedbackSource"></param>
        /// <param name="feedbackConfig"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.FeedbackSchema> CreateFeedbackAsync(
            string key,
            global::System.DateTime? createdAt = default,
            global::System.DateTime? modifiedAt = default,
            global::G.AnyOf<double?, int?, bool?, object>? score = default,
            global::G.AnyOf<double?, int?, bool?, string, global::G.FeedbackCreateSchemaValue, object>? value = default,
            global::G.AnyOf<string, object>? comment = default,
            global::G.AnyOf<global::G.FeedbackCreateSchemaCorrection, string, object>? correction = default,
            global::G.AnyOf<global::System.Guid?, object>? feedbackGroupId = default,
            global::G.AnyOf<global::System.Guid?, object>? comparativeExperimentId = default,
            global::G.AnyOf<global::System.Guid?, object>? runId = default,
            global::G.AnyOf<global::System.Guid?, object>? sessionId = default,
            global::System.Guid? id = default,
            global::G.AnyOf<global::G.AppFeedbackSource, global::G.APIFeedbackSource, global::G.ModelFeedbackSource, global::G.AutoEvalFeedbackSource, object>? feedbackSource = default,
            global::G.AnyOf<global::G.FeedbackConfig, object>? feedbackConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}