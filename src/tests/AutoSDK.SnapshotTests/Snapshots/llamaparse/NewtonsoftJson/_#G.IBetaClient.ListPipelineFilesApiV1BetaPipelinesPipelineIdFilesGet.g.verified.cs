//HintName: G.IBetaClient.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGet.g.cs
#nullable enable

namespace G
{
    public partial interface IBetaClient
    {
        /// <summary>
        /// List Pipeline Files<br/>
        /// List files for a pipeline with pagination and filtering.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="dataSourceId">
        /// Filter by data source ID.
        /// </param>
        /// <param name="fileNameContains">
        /// Filter by files whose names contain this substring (case-insensitive).
        /// </param>
        /// <param name="statuses">
        /// Filter by pipeline file statuses.
        /// </param>
        /// <param name="pageSize">
        /// Maximum number of items to return. Defaults to 50, max 1000.
        /// </param>
        /// <param name="pageToken">
        /// Page token for pagination, from a previous response.
        /// </param>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PipelineFileListResponse> ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetAsync(
            global::System.Guid pipelineId,
            global::System.Guid? dataSourceId = default,
            string? fileNameContains = default,
            global::System.Collections.Generic.IList<global::G.ListPipelineFilesApiV1BetaPipelinesPipelineIdFilesGetStatusesVariant1Item>? statuses = default,
            int? pageSize = default,
            string? pageToken = default,
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}