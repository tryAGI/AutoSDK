//HintName: G.IPipelinesClient.UpsertBatchPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPut.g.cs
#nullable enable

namespace G
{
    public partial interface IPipelinesClient
    {
        /// <summary>
        /// Upsert Batch Pipeline Documents<br/>
        /// Batch create or update a document for a pipeline.
        /// </summary>
        /// <param name="pipelineId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.CloudDocument>> UpsertBatchPipelineDocumentsApiV1PipelinesPipelineIdDocumentsPutAsync(
            global::System.Guid pipelineId,

            global::System.Collections.Generic.IList<global::G.CloudDocumentCreate> request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}