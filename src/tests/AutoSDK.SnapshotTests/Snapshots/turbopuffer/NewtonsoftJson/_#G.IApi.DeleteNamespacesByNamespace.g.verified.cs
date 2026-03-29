//HintName: G.IApi.DeleteNamespacesByNamespace.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Delete namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DeleteNamespacesResponse> DeleteNamespacesByNamespaceAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}