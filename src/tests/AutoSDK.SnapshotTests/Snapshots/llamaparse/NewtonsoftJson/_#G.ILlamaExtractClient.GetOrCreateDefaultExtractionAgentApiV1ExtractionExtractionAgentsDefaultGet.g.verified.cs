//HintName: G.ILlamaExtractClient.GetOrCreateDefaultExtractionAgentApiV1ExtractionExtractionAgentsDefaultGet.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Or Create Default Extraction Agent<br/>
        /// Get or create a default extraction agent for the current project.<br/>
        /// The default agent has an empty schema and default configuration.
        /// </summary>
        /// <param name="projectId"></param>
        /// <param name="organizationId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractAgent> GetOrCreateDefaultExtractionAgentApiV1ExtractionExtractionAgentsDefaultGetAsync(
            global::System.Guid? projectId = default,
            global::System.Guid? organizationId = default,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}