//HintName: G.IDatasetsClient.GetDatasetRows.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Get Dataset Rows<br/>
        /// Retrieve paginated rows from a dataset. Each row is an array of cells matching the order of the `columns` array. All cells have `{"type": "dataset", "value": ...}`.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="workspaceId"></param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="perPage">
        /// Default Value: 10
        /// </param>
        /// <param name="q"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetDatasetRowsResponse> GetDatasetRowsAsync(
            int datasetId,
            int? workspaceId = default,
            int? page = default,
            int? perPage = default,
            string? q = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}