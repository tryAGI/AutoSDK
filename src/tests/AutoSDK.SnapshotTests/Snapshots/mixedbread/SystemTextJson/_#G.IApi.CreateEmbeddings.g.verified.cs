//HintName: G.IApi.CreateEmbeddings.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Create embeddings for text and images<br/>
        /// Create embeddings for text or images using the specified model, encoding format, and normalization.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating embeddings.<br/>
        /// Returns:<br/>
        ///     EmbeddingCreateResponse: The response containing the embeddings.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingCreateResponse> CreateEmbeddingsAsync(

            global::G.EmbeddingCreateParams request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create embeddings for text and images<br/>
        /// Create embeddings for text or images using the specified model, encoding format, and normalization.<br/>
        /// Args:<br/>
        ///     params: The parameters for creating embeddings.<br/>
        /// Returns:<br/>
        ///     EmbeddingCreateResponse: The response containing the embeddings.
        /// </summary>
        /// <param name="model">
        /// The model to use for creating embeddings.
        /// </param>
        /// <param name="input">
        /// The input to create embeddings for.
        /// </param>
        /// <param name="dimensions">
        /// The number of dimensions to use for the embeddings.
        /// </param>
        /// <param name="prompt">
        /// The prompt to use for the embedding creation.
        /// </param>
        /// <param name="normalized">
        /// Whether to normalize the embeddings.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="encodingFormat">
        /// The encoding format(s) of the embeddings. Can be a single format or a list of formats.<br/>
        /// Default Value: float
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingCreateResponse> CreateEmbeddingsAsync(
            string model,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            int? dimensions = default,
            string? prompt = default,
            bool? normalized = default,
            global::G.AnyOf<global::G.EncodingFormat3?, global::System.Collections.Generic.IList<global::G.EncodingFormat3>>? encodingFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}