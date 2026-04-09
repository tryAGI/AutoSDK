//HintName: G.IDatasetsClient.GetDatasetExamples.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get examples from a dataset
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="versionId">
        /// The ID of the dataset version (if omitted, returns data from the latest version)
        /// </param>
        /// <param name="split">
        /// List of dataset split identifiers (GlobalIDs or names) to filter by
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDatasetExamplesResponseBody> GetDatasetExamplesAsync(
            string id,
            string? versionId = default,
            global::System.Collections.Generic.IList<string>? split = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}