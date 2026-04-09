//HintName: G.ILlamaExtractClient.GetLatestRunFromUiApiV1ExtractionRunsLatestFromUiGet.g.cs
#nullable enable

namespace G
{
    public partial interface ILlamaExtractClient
    {
        /// <summary>
        /// Get Latest Run From Ui
        /// </summary>
        /// <param name="extractionAgentId"></param>
        /// <param name="session"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ExtractRun> GetLatestRunFromUiApiV1ExtractionRunsLatestFromUiGetAsync(
            global::System.Guid extractionAgentId,
            string? session = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}