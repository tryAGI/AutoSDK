//HintName: G.IOptimizationsClient.FindOptimizations.g.cs
#nullable enable

namespace G
{
    public partial interface IOptimizationsClient
    {
        /// <summary>
        /// Find optimizations<br/>
        /// Find optimizations
        /// </summary>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="size">
        /// Default Value: 10
        /// </param>
        /// <param name="datasetId"></param>
        /// <param name="name">
        /// Filter optimizations by name (partial match, case insensitive)
        /// </param>
        /// <param name="datasetName">
        /// Filter optimizations by dataset name (partial match)
        /// </param>
        /// <param name="datasetDeleted"></param>
        /// <param name="projectId"></param>
        /// <param name="filters"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.OptimizationPagePublic> FindOptimizationsAsync(
            int? page = default,
            int? size = default,
            global::System.Guid? datasetId = default,
            string? name = default,
            string? datasetName = default,
            bool? datasetDeleted = default,
            global::System.Guid? projectId = default,
            string? filters = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}