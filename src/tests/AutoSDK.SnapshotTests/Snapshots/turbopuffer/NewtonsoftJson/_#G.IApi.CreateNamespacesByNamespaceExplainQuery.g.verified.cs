//HintName: G.IApi.CreateNamespacesByNamespaceExplainQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Explain a query plan.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespacesExplainQueryResponse> CreateNamespacesByNamespaceExplainQueryAsync(
            string @namespace,

            global::G.AllOf<global::G.QueryConfig, global::G.Query> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Explain a query plan.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateNamespacesExplainQueryResponse> CreateNamespacesByNamespaceExplainQueryAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}