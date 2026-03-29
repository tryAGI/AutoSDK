//HintName: G.IPipelinesClient.SyncPipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdSyncPost.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Sync Pipeline Document<br/>
        /// Sync a specific document for a pipeline.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> SyncPipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdSyncPostAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}