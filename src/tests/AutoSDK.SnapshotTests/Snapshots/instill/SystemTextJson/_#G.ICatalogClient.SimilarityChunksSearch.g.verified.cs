//HintName: G.ICatalogClient.SimilarityChunksSearch.g.cs
#nullable enable

namespace G
{
    public partial interface ICatalogClient
    {
        /// <summary>
        /// Retrieve similar chunks
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            global::G.SimilarityChunksSearchBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieve similar chunks
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="catalogId"></param>
        /// <param name="textPrompt"></param>
        /// <param name="topK"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.SimilarityChunksSearchResponse> SimilarityChunksSearchAsync(
            string namespaceId,
            string catalogId,
            string? textPrompt = default,
            long topK = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}