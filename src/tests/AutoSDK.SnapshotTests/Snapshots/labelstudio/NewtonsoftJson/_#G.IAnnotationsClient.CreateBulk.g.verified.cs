//HintName: G.IAnnotationsClient.CreateBulk.g.cs
#nullable enable

namespace G
{
    public partial interface IAnnotationsClient
    {
        /// <summary>
        /// Bulk create annotations<br/>
        /// Create multiple annotations at once
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>> CreateBulkAsync(

            global::G.AnnotationBulkSerializerWithSelectedItemsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Bulk create annotations<br/>
        /// Create multiple annotations at once
        /// </summary>
        /// <param name="bulkCreated">
        /// Annotation was created in bulk mode
        /// </param>
        /// <param name="completedBy"></param>
        /// <param name="draftCreatedAt">
        /// Draft creation time
        /// </param>
        /// <param name="groundTruth">
        /// This annotation is a Ground Truth (ground_truth)
        /// </param>
        /// <param name="importId">
        /// Original annotation ID that was at the import step or NULL if this annotation wasn't imported
        /// </param>
        /// <param name="lastAction">
        /// Action which was performed in the last annotation history item<br/>
        /// * `prediction` - Created from prediction<br/>
        /// * `propagated_annotation` - Created from another annotation<br/>
        /// * `imported` - Imported<br/>
        /// * `submitted` - Submitted<br/>
        /// * `updated` - Updated<br/>
        /// * `skipped` - Skipped<br/>
        /// * `accepted` - Accepted<br/>
        /// * `rejected` - Rejected<br/>
        /// * `fixed_and_accepted` - Fixed and accepted<br/>
        /// * `deleted_review` - Deleted review
        /// </param>
        /// <param name="lastCreatedBy">
        /// User who created the last annotation history item
        /// </param>
        /// <param name="leadTime">
        /// How much time it took to annotate the task
        /// </param>
        /// <param name="parentAnnotation">
        /// Points to the parent annotation from which this annotation was created
        /// </param>
        /// <param name="parentPrediction">
        /// Points to the prediction from which this annotation was created
        /// </param>
        /// <param name="project">
        /// Project ID for this annotation
        /// </param>
        /// <param name="result">
        /// List of annotation results for the task
        /// </param>
        /// <param name="selectedItems"></param>
        /// <param name="task">
        /// Corresponding task for this annotation
        /// </param>
        /// <param name="tasks"></param>
        /// <param name="uniqueId">
        /// Included only in requests
        /// </param>
        /// <param name="updatedBy">
        /// Last user who updated this annotation
        /// </param>
        /// <param name="wasCancelled">
        /// User skipped the task
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.ApiAnnotationsBulkCreateResponseItem>> CreateBulkAsync(
            string uniqueId,
            bool? bulkCreated = default,
            int? completedBy = default,
            global::System.DateTime? draftCreatedAt = default,
            bool? groundTruth = default,
            long? importId = default,
            global::G.LastActionEnum? lastAction = default,
            int? lastCreatedBy = default,
            double? leadTime = default,
            int? parentAnnotation = default,
            int? parentPrediction = default,
            int? project = default,
            global::System.Collections.Generic.IList<object>? result = default,
            global::G.SelectedItemsRequest? selectedItems = default,
            int? task = default,
            global::System.Collections.Generic.IList<int>? tasks = default,
            int? updatedBy = default,
            bool? wasCancelled = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}