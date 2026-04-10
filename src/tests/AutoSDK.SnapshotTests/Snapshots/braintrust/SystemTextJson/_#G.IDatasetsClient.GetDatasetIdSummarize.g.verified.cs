//HintName: G.IDatasetsClient.GetDatasetIdSummarize.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Summarize dataset<br/>
        /// Summarize dataset
        /// </summary>
        /// <param name="datasetId">
        /// Dataset id
        /// </param>
        /// <param name="summarizeData">
        /// Whether to summarize the data. If false (or omitted), only the metadata will be returned.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SummarizeDatasetResponse> GetDatasetIdSummarizeAsync(
            global::System.Guid datasetId,
            bool? summarizeData = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}