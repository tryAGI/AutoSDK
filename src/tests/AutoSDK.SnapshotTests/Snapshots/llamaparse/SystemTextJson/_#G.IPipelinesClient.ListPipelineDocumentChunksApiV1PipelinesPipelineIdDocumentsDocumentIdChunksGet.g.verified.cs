//HintName: G.IPipelinesClient.ListPipelineDocumentChunksApiV1PipelinesPipelineIdDocumentsDocumentIdChunksGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// List Pipeline Document Chunks<br/>
        /// Return a list of chunks for a pipeline document.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TextNode>> ListPipelineDocumentChunksApiV1PipelinesPipelineIdDocumentsDocumentIdChunksGetAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}