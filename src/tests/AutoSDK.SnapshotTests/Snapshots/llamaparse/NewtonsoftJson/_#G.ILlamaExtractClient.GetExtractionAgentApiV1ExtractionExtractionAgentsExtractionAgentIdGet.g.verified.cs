//HintName: G.ILlamaExtractClient.GetExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Extraction Agent
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractAgent> GetExtractionAgentApiV1ExtractionExtractionAgentsExtractionAgentIdGetAsync(
            global::System.Guid extractionAgentId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}