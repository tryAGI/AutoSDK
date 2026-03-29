//HintName: G.IApi.GetNamespacesByNamespaceMetadata.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get metadata about a namespace.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.NamespaceMetadata> GetNamespacesByNamespaceMetadataAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}