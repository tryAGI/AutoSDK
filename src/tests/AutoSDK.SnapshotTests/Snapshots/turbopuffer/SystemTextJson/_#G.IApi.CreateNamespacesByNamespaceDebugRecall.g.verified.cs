//HintName: G.IApi.CreateNamespacesByNamespaceDebugRecall.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Evaluate recall.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespacesDebugRecallResponse> CreateNamespacesByNamespaceDebugRecallAsync(
            string @namespace,

            global::G.CreateNamespacesDebugRecallRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Evaluate recall.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="num">
        /// The number of searches to run.
        /// </param>
        /// <param name="topK">
        /// Search for `top_k` nearest neighbors.
        /// </param>
        /// <param name="filters">
        /// Filter by attributes. Same syntax as the query endpoint.
        /// </param>
        /// <param name="includeGroundTruth">
        /// Include ground truth data (query vectors and true nearest neighbors) in the response.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespacesDebugRecallResponse> CreateNamespacesByNamespaceDebugRecallAsync(
            string @namespace,
            int? num = default,
            int? topK = default,
            object? filters = default,
            bool? includeGroundTruth = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}