//HintName: G.IEmbeddingsClient.EmbeddingsV1EmbeddingsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IEmbeddingsClient
    {
        /// <summary>
        /// Embeddings<br/>
        /// Embeddings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> EmbeddingsV1EmbeddingsPostAsync(

            global::G.EmbeddingRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Embeddings
        /// </summary>
        /// <param name="model">
        /// ID of the model to use.<br/>
        /// Example: mistral-embed
        /// </param>
        /// <param name="input">
        /// Text to embed.<br/>
        /// Example: [Embed this sentence., As well as this one.]
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingResponse> EmbeddingsV1EmbeddingsPostAsync(
            string model,
            global::G.AnyOf<string, global::System.Collections.Generic.IList<string>> input,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}