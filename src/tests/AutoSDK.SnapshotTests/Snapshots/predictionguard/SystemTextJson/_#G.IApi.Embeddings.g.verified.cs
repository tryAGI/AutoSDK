//HintName: G.IApi.Embeddings.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Embeddings<br/>
        /// Generate vector data points from text and images.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsResponse200> EmbeddingsAsync(

            global::G.EmbeddingsRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Embeddings<br/>
        /// Generate vector data points from text and images.
        /// </summary>
        /// <param name="model">
        /// The model to use for generating vectors.
        /// </param>
        /// <param name="input"></param>
        /// <param name="truncate">
        /// Boolean setting whether to truncate inputs. Not supported by bridgetower.
        /// </param>
        /// <param name="truncationDirection">
        /// Which direction to truncate, "Left" or "Right". Not supported by bridgetower.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.EmbeddingsResponse200> EmbeddingsAsync(
            string model,
            global::G.EmbeddingsPostRequestBodyContentApplicationJsonSchemaInput input,
            bool? truncate = default,
            string? truncationDirection = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}