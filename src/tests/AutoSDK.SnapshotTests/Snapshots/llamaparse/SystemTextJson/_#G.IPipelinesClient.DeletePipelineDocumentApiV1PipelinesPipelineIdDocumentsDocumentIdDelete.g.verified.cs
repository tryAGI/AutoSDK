//HintName: G.IPipelinesClient.DeletePipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdDelete.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Delete Pipeline Document<br/>
        /// Delete a document from a pipeline.<br/>
        /// Initiates an async job that will:<br/>
        /// 1. Delete vectors from the vector store<br/>
        /// 2. Delete the document from MongoDB after vectors are successfully deleted
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task DeletePipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdDeleteAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}