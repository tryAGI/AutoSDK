//HintName: G.ISubpackageEmbeddingsClient.CreateEmbeddings.g.cs
#nullable enable

namespace G
{
    public partial interface ISubpackageEmbeddingsClient
    {
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsCreateEmbeddingsResponse200> CreateEmbeddingsAsync(

            global::G.CreateEmbeddingsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit an embedding request<br/>
        /// Submits an embedding request to the embeddings router
        /// </summary>
        /// <param name="input"></param>
        /// <param name="model"></param>
        /// <param name="encodingFormat"></param>
        /// <param name="dimensions"></param>
        /// <param name="user"></param>
        /// <param name="provider">
        /// Provider routing preferences for the request.
        /// </param>
        /// <param name="inputType"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsCreateEmbeddingsResponse200> CreateEmbeddingsAsync(
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            string model,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaEncodingFormat? encodingFormat = default,
            int? dimensions = default,
            string? user = default,
            global::G.ProviderPreferences? provider = default,
            string? inputType = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}