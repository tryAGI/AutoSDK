//HintName: G.IDatasetsClient.DownloadDatasetOpenai.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Download Dataset Openai<br/>
        /// Download a dataset as OpenAI Evals Jsonl format.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="asOf">
        /// Only modifications made on or before this time are included. If None, the latest version of the dataset is used.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DownloadDatasetOpenaiAsync(
            global::System.Guid datasetId,
            global::System.DateTime? asOf = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}