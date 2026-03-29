//HintName: G.IApi.GetNamespaces.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// List namespaces.
        /// </summary>
        /// <param name="cursor"></param>
        /// <param name="prefix"></param>
        /// <param name="pageSize"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetNamespacesResponse> GetNamespacesAsync(
            string? cursor = default,
            string? prefix = default,
            int? pageSize = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}