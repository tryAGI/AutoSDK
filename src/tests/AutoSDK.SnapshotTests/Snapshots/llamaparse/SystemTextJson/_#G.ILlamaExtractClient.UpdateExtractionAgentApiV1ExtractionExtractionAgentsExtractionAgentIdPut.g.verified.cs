//HintName: G.ILlamaExtractClient.UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPut.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Update Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractAgent> UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutAsync(
            global::System.Guid extractionAgentId,

            global::G.ExtractAgentUpdate request,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="dataSchema">
        /// The schema of the data
        /// </param>
        /// <param name="config">
        /// The configuration parameters for the extraction agent.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractAgent> UpdateExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdPutAsync(
            global::System.Guid extractionAgentId,
            global::G.AnyOf<object, string> dataSchema,
            global::G.ExtractConfig config,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}