//HintName: G.IApi.OpenaiEmbeddingsV1OpenaiEmbeddingsPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
            global::G.OpenAIEmbeddingsIn request,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Openai Embeddings
        /// </summary>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="userAgent"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="model">
        /// model name
        /// </param>
        /// <param name="input">
        /// sequences to embed
        /// </param>
        /// <param name="encodingFormat">
        /// format used when encoding<br/>
        /// Default Value: float
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> OpenaiEmbeddingsV1OpenaiEmbeddingsPostAsync(
            string model,
            global::G.AnyOf<global::System.Collections.Generic.IList<string>, string> input,
            string? xDeepinfraSource = default,
            string? userAgent = default,
            string? xiApiKey = default,
            string? encodingFormat = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}