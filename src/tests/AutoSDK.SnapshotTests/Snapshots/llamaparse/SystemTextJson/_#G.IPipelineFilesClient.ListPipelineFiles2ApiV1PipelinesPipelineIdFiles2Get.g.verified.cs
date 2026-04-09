//HintName: G.IPipelineFilesClient.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2Get.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelineFilesClient
    {
        /// <summary>
        /// List Pipeline Files2<br/>
        /// List files for a pipeline with optional filtering, sorting, and pagination.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="dataSourceId"></param>
        /// <param name="onlyManuallyUploaded">
        /// Default Value: false
        /// </param>
        /// <param name="fileNameContains"></param>
        /// <param name="statuses">
        /// Filter by file statuses
        /// </param>
        /// <param name="limit"></param>
        /// <param name="offset"></param>
        /// <param name="orderBy"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.PaginatedListPipelineFilesResponse> ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetAsync(
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId = default,
            bool? onlyManuallyUploaded = default,
            string? fileNameContains = default,
            global::System.Collections.Generic.IList<global::G.ListPipelineFiles2ApiV1PipelinesPipelineIdFiles2GetStatusesVariant1Item>? statuses = default,
            int? limit = default,
            int? offset = default,
            string? orderBy = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}