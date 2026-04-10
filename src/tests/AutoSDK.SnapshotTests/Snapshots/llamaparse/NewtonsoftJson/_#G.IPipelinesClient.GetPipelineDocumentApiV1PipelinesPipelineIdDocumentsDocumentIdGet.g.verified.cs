//HintName: G.IPipelinesClient.GetPipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Get Pipeline Document<br/>
        /// Return a single document for a pipeline.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CloudDocument> GetPipelineDocumentApiV1PipelinesPipelineIdDocumentsDocumentIdGetAsync(
            string documentId,
            global::System.Guid pipelineId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}