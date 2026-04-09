//HintName: G.IBetaClient.CreateBatchJobApiV1BetaBatchProcessingPost.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a batch processing job.<br/>
        /// Processes files from a directory or a specific list of item IDs.<br/>
        /// Supports batch parsing and classification operations.<br/>
        /// Provide either `directory_id` to process all files in a directory,<br/>
        /// or `item_ids` for specific items. The job runs asynchronously —<br/>
        /// poll `GET /batch/{job_id}` for progress.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobResponse> CreateBatchJobApiV1BetaBatchProcessingPostAsync(

            global::G.BatchJobCreateRequest request,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch Job<br/>
        /// Create a batch processing job.<br/>
        /// Processes files from a directory or a specific list of item IDs.<br/>
        /// Supports batch parsing and classification operations.<br/>
        /// Provide either `directory_id` to process all files in a directory,<br/>
        /// or `item_ids` for specific items. The job runs asynchronously —<br/>
        /// poll `GET /batch/{job_id}` for progress.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="temporalNamespace"></param>
        /// <param name="session"></param>
        /// <param name="directoryId">
        /// ID of the directory containing files to process
        /// </param>
        /// <param name="itemIds">
        /// List of specific item IDs to process. Either this or directory_id must be provided.
        /// </param>
        /// <param name="jobConfig">
        /// Job configuration — either a parse or classify config
        /// </param>
        /// <param name="pageSize">
        /// Number of files to process per batch when using directory mode<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="continueAsNewThreshold">
        /// Maximum files to process per execution cycle in directory mode. Defaults to page_size.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.BatchJobResponse> CreateBatchJobApiV1BetaBatchProcessingPostAsync(
            global::G.AnyOf<global::G.BatchParseJobRecordCreate, global::G.ClassifyJob> jobConfig,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? temporalNamespace = default,
            string? session = default,
            string? directoryId = default,
            global::System.Collections.Generic.IList<string>? itemIds = default,
            int? pageSize = default,
            int? continueAsNewThreshold = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}