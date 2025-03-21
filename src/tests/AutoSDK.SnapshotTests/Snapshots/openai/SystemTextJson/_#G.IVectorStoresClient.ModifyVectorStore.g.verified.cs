//HintName: G.IVectorStoresClient.ModifyVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            global::G.UpdateVectorStoreRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Modifies a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="expiresAfter">
        /// The expiration policy for a vector store.
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
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> ModifyVectorStoreAsync(
            string vectorStoreId,
            global::G.VectorStoreExpirationAfter? expiresAfter = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            string? name = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}