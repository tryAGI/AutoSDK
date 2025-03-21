//HintName: G.IVectorStoresClient.CreateVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Create a vector store.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> CreateVectorStoreAsync(
            global::G.CreateVectorStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a vector store.
        /// </summary>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy. Only applicable if `file_ids` is non-empty.
        /// </param>
        /// <param name="expiresAfter">
        /// The expiration policy for a vector store.
        /// </param>
        /// <param name="fileIds">
        /// A list of [File](/docs/api-reference/files) IDs that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="name">
        /// The name of the vector store.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> CreateVectorStoreAsync(
            global::G.OneOf<global::G.AutoChunkingStrategyRequestParam, global::G.StaticChunkingStrategyRequestParam>? chunkingStrategy = default,
            global::G.VectorStoreExpirationAfter? expiresAfter = default,
            global::System.Collections.Generic.IList<string>? fileIds = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}