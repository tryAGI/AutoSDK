//HintName: G.IDatasetsClient.ListDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// List Datasets
        /// </summary>
        /// <param name="page"></param>
        /// <param name="size"></param>
        /// <param name="name"></param>
        /// <param name="sortBy"></param>
        /// <param name="order"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.PaginatedDatasetResponse> ListDatasetsAsync(
            int? page = default,
            int? size = default,
            string? name = default,
            string? sortBy = default,
            global::G.ListDatasetsOrder? order = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}