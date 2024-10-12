//HintName: G.IEmbeddingsClient.Embeddings.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Create embedding<br/>
        /// Query an embedding model for a given string of text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsResponse> EmbeddingsAsync(
            global::G.EmbeddingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create embedding<br/>
        /// Query an embedding model for a given string of text.
        /// </summary>
        /// <param name="input">
        /// Default Value: Our solar system orbits the Milky Way galaxy at about 515,000 mph
        /// </param>
        /// <param name="model">
        /// The name of the embedding model to use.<br/>
        /// Default Value: togethercomputer/m2-bert-80M-8k-retrieval<br/>
        /// Example: togethercomputer/m2-bert-80M-8k-retrieval
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsResponse> EmbeddingsAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            string model,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}