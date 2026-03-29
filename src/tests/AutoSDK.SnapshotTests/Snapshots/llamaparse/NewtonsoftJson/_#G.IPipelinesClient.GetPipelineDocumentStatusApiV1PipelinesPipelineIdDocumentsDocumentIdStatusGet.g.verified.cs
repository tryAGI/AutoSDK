//HintName: G.IPipelinesClient.GetPipelineDocumentStatusApiV1PipelinesPipelineIdDocumentsDocumentIdStatusGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline Document Status<br/>
        /// Return a single document for a pipeline.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ManagedIngestionStatusResponse> GetPipelineDocumentStatusApiV1PipelinesPipelineIdDocumentsDocumentIdStatusGetAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}