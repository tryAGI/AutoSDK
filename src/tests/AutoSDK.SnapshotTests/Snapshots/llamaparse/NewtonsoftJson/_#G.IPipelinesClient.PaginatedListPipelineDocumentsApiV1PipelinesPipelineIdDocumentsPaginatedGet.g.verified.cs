//HintName: G.IPipelinesClient.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Paginated List Pipeline Documents<br/>
        /// Return a list of documents for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="skip">
        /// Default Value: 0
        /// </param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="fileId"></param>
        /// <param name="onlyDirectUpload">
        /// Default Value: false
        /// </param>
        /// <param name="onlyApiDataSourceDocuments">
        /// Default Value: false
        /// </param>
        /// <param name="statusRefreshPolicy">
        /// Default Value: cached
        /// </param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedListCloudDocumentsResponse> PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetAsync(
            global::System.Guid pipelineId,
            int? skip = default,
            int? limit = default,
            global::System.Guid? fileId = default,
            bool? onlyDirectUpload = default,
            bool? onlyApiDataSourceDocuments = default,
            global::G.PaginatedListPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPaginatedGetStatusRefreshPolicy? statusRefreshPolicy = default,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}