//HintName: G.IVectorStoresClient.GetVectorStore.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieves a vector store.
        /// </summary>
        /// <param name="vectorStoreId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "G_BETA_001")]
#endif
        global::System.Threading.Tasks.Task<global::G.VectorStoreObject> GetVectorStoreAsync(
            string vectorStoreId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}