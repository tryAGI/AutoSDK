//HintName: G.ITasks2Client.Update2.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Update task<br/>
        /// Update the attributes of an existing labeling task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.RoleBasedTask> Update2Async(
            string id,

            global::G.PatchedLseTaskRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update task<br/>
        /// Update the attributes of an existing labeling task.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="allowSkip">
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </param>
        /// <param name="avgLeadTime"></param>
        /// <param name="cancelledAnnotations"></param>
        /// <param name="commentCount">
        /// Number of comments in the task including all annotations
        /// </param>
        /// <param name="completedAt"></param>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="draftExists"></param>
        /// <param name="groundTruth"></param>
        /// <param name="innerId"></param>
        /// <param name="isLabeled">
        /// True if the number of annotations for this task is greater than or equal to the number of maximum_completions for the project
        /// </param>
        /// <param name="lastCommentUpdatedAt">
        /// When the last comment was updated
        /// </param>
        /// <param name="meta">
        /// Meta is user imported (uploaded) data and can be useful as input for an ML Backend for embeddings, advanced vectors, and other info. It is passed to ML during training/predicting steps.
        /// </param>
        /// <param name="overlap">
        /// Number of distinct annotators that processed the current task
        /// </param>
        /// <param name="precomputedAgreement">
        /// Average agreement score for the task
        /// </param>
        /// <param name="predictionsScore"></param>
        /// <param name="project">
        /// Project ID for this task
        /// </param>
        /// <param name="reviewed"></param>
        /// <param name="reviewsAccepted"></param>
        /// <param name="reviewsRejected"></param>
        /// <param name="totalAnnotations"></param>
        /// <param name="totalPredictions"></param>
        /// <param name="unresolvedCommentCount">
        /// Number of unresolved comments in the task including all annotations
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.RoleBasedTask> Update2Async(
            string id,
            bool? allowSkip = default,
            double? avgLeadTime = default,
            int? cancelledAnnotations = default,
            int? commentCount = default,
            global::System.DateTime? completedAt = default,
            object? data = default,
            bool? draftExists = default,
            bool? groundTruth = default,
            int? innerId = default,
            bool? isLabeled = default,
            global::System.DateTime? lastCommentUpdatedAt = default,
            object? meta = default,
            int? overlap = default,
            double? precomputedAgreement = default,
            double? predictionsScore = default,
            int? project = default,
            bool? reviewed = default,
            int? reviewsAccepted = default,
            int? reviewsRejected = default,
            int? totalAnnotations = default,
            int? totalPredictions = default,
            int? unresolvedCommentCount = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}