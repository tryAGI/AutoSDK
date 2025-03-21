//HintName: G.IVectorStoresClient.CreateVectorStoreFile.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Create a vector store file by attaching a [File](/docs/api-reference/files) to a [vector store](/docs/api-reference/vector-stores/object).
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileObject> CreateVectorStoreFileAsync(
            string vectorStoreId,
            global::G.CreateVectorStoreFileRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a vector store file by attaching a [File](/docs/api-reference/files) to a [vector store](/docs/api-reference/vector-stores/object).
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="attributes">
        /// Set of 16 key-value pairs that can be attached to an object. This can be <br/>
        /// useful for storing additional information about the object in a structured <br/>
        /// format, and querying for objects via API or the dashboard. Keys are strings <br/>
        /// with a maximum length of 64 characters. Values are strings with a maximum <br/>
        /// length of 512 characters, booleans, or numbers.
        /// </param>
        /// <param name="chunkingStrategy">
        /// The chunking strategy used to chunk the file(s). If not set, will use the `auto` strategy.
        /// </param>
        /// <param name="fileId">
        /// A [File](/docs/api-reference/files) ID that the vector store should use. Useful for tools like `file_search` that can access files.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileObject> CreateVectorStoreFileAsync(
            string vectorStoreId,
            string fileId,
            object? attributes = default,
            global::G.ChunkingStrategyRequestParam? chunkingStrategy = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}