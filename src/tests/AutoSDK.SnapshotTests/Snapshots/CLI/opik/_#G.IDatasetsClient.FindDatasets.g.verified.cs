//HintName: G.IDatasetsClient.FindDatasets.g.cs
#nullable enable

namespace G
{
    public partial interface IDatasetsClient
    {
        /// <summary>
        /// Find datasets<br/>
        /// Find datasets
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="withExperimentsOnly"></param>
        /// <param name="withOptimizationsOnly"></param>
        /// <param name="promptId"></param>
        /// <param name="projectId"></param>
        /// <param name="name">
        /// Filter datasets by name (partial match, case insensitive)
        /// </param>
        /// <param name="sorting"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DatasetPagePublic> FindDatasetsAsync(
            int? page = default,
            int? size = default,
            bool? withExperimentsOnly = default,
            bool? withOptimizationsOnly = default,
            global::System.Guid? promptId = default,
            global::System.Guid? projectId = default,
            string? name = default,
            string? sorting = default,
            string? filters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}