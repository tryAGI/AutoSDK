//HintName: G.IEmbeddingsClient.CreateEmbedding.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(

            global::G.CreateEmbeddingRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates an embedding vector representing the input text.
        /// </summary>
        /// <param name="input">
        /// Input text to embed, encoded as a string or array of tokens. To embed multiple inputs in a single request, pass an array of strings or array of token arrays. The input must not exceed the max input tokens for the model, cannot be an empty string, and any array must be 2048 dimensions or less.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </param>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: nomic-embed-text-v1_5
        /// </param>
        /// <param name="encodingFormat">
        /// The format to return the embeddings in. Can only be `float` or `base64`.<br/>
        /// Default Value: float<br/>
        /// Example: float
        /// </param>
        /// <param name="user">
        /// A unique identifier representing your end-user, which can help us monitor and detect abuse.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateEmbeddingResponse> CreateEmbeddingAsync(
            global::G.OneOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AnyOf<string, global::G.CreateEmbeddingRequestModel?> model,
            global::G.CreateEmbeddingRequestEncodingFormat? encodingFormat = default,
            string? user = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}