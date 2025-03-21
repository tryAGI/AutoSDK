//HintName: G.IVectorStoresClient.RetrieveVectorStoreFileContent.g.cs
#nullable enable

namespace G
{
    public partial interface IVectorStoresClient
    {
        /// <summary>
        /// Retrieve the parsed contents of a vector store file.
        /// </summary>
        /// <param name="vectorStoreId">
        /// Example: vs_abc123
        /// </param>
        /// <param name="fileId">
        /// Example: file-abc123
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VectorStoreFileContentResponse> RetrieveVectorStoreFileContentAsync(
            string vectorStoreId,
            string fileId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}