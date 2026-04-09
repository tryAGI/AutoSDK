//HintName: G.IDataExplorerClient.ApiDatasetsTasksMetadataRetrieve.g.cs
#nullable enable

namespace G
{
    public partial interface IDataExplorerClient
    {
        /// <summary>
        /// Get Candidate task metadata<br/>
        ///     Retrieve Candidate task metadata for a specific dataset, by using candidate_task_id or weaviate_id.<br/>
        ///     
        /// </summary>
        /// <param name="candidateTaskId"></param>
        /// <param name="dataset"></param>
        /// <param name="vectordbId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task ApiDatasetsTasksMetadataRetrieveAsync(
            string? candidateTaskId = default,
            int? dataset = default,
            string? vectordbId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}