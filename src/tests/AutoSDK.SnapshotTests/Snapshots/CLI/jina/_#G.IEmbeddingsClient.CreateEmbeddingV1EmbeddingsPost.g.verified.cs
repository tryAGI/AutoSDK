//HintName: G.IEmbeddingsClient.CreateEmbeddingV1EmbeddingsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create Embedding<br/>
        /// Create embedding representations of the given input texts.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelEmbeddingOutput> CreateEmbeddingV1EmbeddingsPostAsync(
            global::G.EmbeddingInput request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create Embedding<br/>
        /// Create embedding representations of the given input texts.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ModelEmbeddingOutput> CreateEmbeddingV1EmbeddingsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}