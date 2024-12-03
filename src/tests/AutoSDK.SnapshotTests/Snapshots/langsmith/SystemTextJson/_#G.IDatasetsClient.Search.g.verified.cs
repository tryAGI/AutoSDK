//HintName: G.IDatasetsClient.Search.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchDatasetResponse> SearchAsync(
            global::System.Guid datasetId,
            global::G.SearchDatasetRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Search<br/>
        /// Search a dataset.
        /// </summary>
        /// <param name="datasetId"></param>
        /// <param name="inputs"></param>
        /// <param name="limit">
        /// Default Value: 5
        /// </param>
        /// <param name="debug">
        /// Default Value: false
        /// </param>
        /// <param name="filter"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SearchDatasetResponse> SearchAsync(
            global::System.Guid datasetId,
            object inputs,
            int? limit = default,
            bool? debug = default,
            string? filter = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}