//HintName: G.IDatasetsClient.GetDatasetJSONLOpenAIEvals.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Download dataset examples as OpenAI evals JSONL file
        /// </summary>
        /// <param name="id">
        /// The ID of the dataset
        /// </param>
        /// <param name="versionId">
        /// The ID of the dataset version (if omitted, returns data from the latest version)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetDatasetJSONLOpenAIEvalsAsync(
            string id,
            string? versionId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}