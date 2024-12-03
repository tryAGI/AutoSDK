//HintName: G.IVectorStoresClient.GetVectorStoreFileBatch.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieves a vector store file batch.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="batchId">
        /// Example: vsfb_abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileBatchObject> GetVectorStoreFileBatchAsync(
            string vectorStoreId,
            string batchId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}