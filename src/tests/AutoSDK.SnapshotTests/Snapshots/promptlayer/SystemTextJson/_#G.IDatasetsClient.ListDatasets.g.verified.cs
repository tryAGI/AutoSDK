//HintName: G.IDatasetsClient.ListDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="datasetGroupId"></param>
        /// <param name="promptId"></param>
        /// <param name="promptVersionId"></param>
        /// <param name="promptLabelId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="reportId"></param>
        /// <param name="name"></param>
        /// <param name="status">
        /// Default Value: active
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListDatasetsResponse> ListDatasetsAsync(
            int? datasetGroupId = default,
            int? promptId = default,
            int? promptVersionId = default,
            int? promptLabelId = default,
            int? workspaceId = default,
            int? reportId = default,
            string? name = default,
            global::G.ListDatasetsStatus? status = default,
            int? page = default,
            int? perPage = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}