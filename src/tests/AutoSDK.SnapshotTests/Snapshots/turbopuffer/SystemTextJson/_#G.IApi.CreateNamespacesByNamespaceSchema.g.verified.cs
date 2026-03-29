//HintName: G.IApi.CreateNamespacesByNamespaceSchema.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update namespace schema.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::G.AttributeSchemaConfig>> CreateNamespacesByNamespaceSchemaAsync(
            string @namespace,

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update namespace schema.
        /// </summary>
        /// <param name="namespace"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.Dictionary<string, global::G.AttributeSchemaConfig>> CreateNamespacesByNamespaceSchemaAsync(
            string @namespace,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}