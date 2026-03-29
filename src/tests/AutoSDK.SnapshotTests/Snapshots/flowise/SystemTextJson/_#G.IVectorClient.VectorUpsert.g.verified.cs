//HintName: G.IVectorClient.VectorUpsert.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorClient
    {
        /// <summary>
        /// Upsert vector embeddings<br/>
        /// Upsert vector embeddings of documents in a chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorUpsertResponse> VectorUpsertAsync(
            string id,

            global::G.VectorUpsertRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upsert vector embeddings<br/>
        /// Upsert vector embeddings of documents in a chatflow
        /// </summary>
        /// <param name="id"></param>
        /// <param name="stopNodeId">
        /// In cases when you have multiple vector store nodes, you can specify the node ID to store the vectors<br/>
        /// Example: node_1
        /// </param>
        /// <param name="overrideConfig">
        /// The configuration to override the default vector upsert settings (optional)
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorUpsertResponse> VectorUpsertAsync(
            string id,
            string? stopNodeId = default,
            object? overrideConfig = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}