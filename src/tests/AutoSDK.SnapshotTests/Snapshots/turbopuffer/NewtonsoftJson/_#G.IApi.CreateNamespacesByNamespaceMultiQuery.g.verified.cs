//HintName: G.IApi.CreateNamespacesByNamespaceMultiQuery.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Issue multiple concurrent queries filter or search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultiQueryResult> CreateNamespacesByNamespaceMultiQueryAsync(
            string @namespace,

            global::G.AllOf<global::G.QueryConfig, global::G.CreateNamespacesMultiQueryRequest2> request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Issue multiple concurrent queries filter or search documents.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.MultiQueryResult> CreateNamespacesByNamespaceMultiQueryAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}