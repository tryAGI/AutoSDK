//HintName: G.ITasks2Client.Create.g.cs
#nullable enable

namespace G
{
    public partial interface ITasks2Client
    {
        /// <summary>
        /// Create a new task<br/>
        /// Create a new task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseTask> CreateAsync(

            global::G.LseTaskRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new task<br/>
        /// Create a new task
        /// </summary>
        /// <param name="allowSkip">
        /// Whether this task can be skipped. Set to False to make task unskippable.
        /// </param>
        /// <param name="cancelledAnnotations">
        /// Number of total cancelled annotations for the current task
        /// </param>
        /// <param name="commentAuthors">
        /// Users who wrote comments
        /// </param>
        /// <param name="commentCount">
        /// Number of comments in the task including all annotations
        /// </param>
        /// <param name="data">
        /// User imported or uploaded data for a task. Data is formatted according to the project label config. You can find examples of data for your project on the Import page in the Label Studio Data Manager UI.
        /// </param>
        /// <param name="fileUpload">
        /// Uploaded file used as data source for this task
        /// </param>
        /// <param name="innerId">
        /// Internal task ID in the project, starts with 1
        /// </param>
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
        /// <param name="project">
        /// Project ID for this task
        /// </param>
        /// <param name="totalAnnotations">
        /// Number of total annotations for the current task except cancelled annotations
        /// </param>
        /// <param name="totalPredictions">
        /// Number of total predictions for the current task
        /// </param>
        /// <param name="unresolvedCommentCount">
        /// Number of unresolved comments in the task including all annotations
        /// </param>
        /// <param name="updatedBy">
        /// Last annotator or reviewer who updated this task
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.LseTask> CreateAsync(
            object data,
            bool? allowSkip = default,
            int? cancelledAnnotations = default,
            global::System.Collections.Generic.IList<int>? commentAuthors = default,
            int? commentCount = default,
            int? fileUpload = default,
            long? innerId = default,
            bool? isLabeled = default,
            global::System.DateTime? lastCommentUpdatedAt = default,
            object? meta = default,
            int? overlap = default,
            int? project = default,
            int? totalAnnotations = default,
            int? totalPredictions = default,
            int? unresolvedCommentCount = default,
            int? updatedBy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}