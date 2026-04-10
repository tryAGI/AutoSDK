//HintName: G.IApi.Tokenize.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Tokenize<br/>
        /// Generates tokens for a string using a model's tokenizer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenizeResponse200> TokenizeAsync(

            global::G.TokenizeRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Tokenize<br/>
        /// Generates tokens for a string using a model's tokenizer.
        /// </summary>
        /// <param name="model">
        /// The name of the model to use for tokenization.
        /// </param>
        /// <param name="input">
        /// The text to tokenize.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenizeResponse200> TokenizeAsync(
            string model,
            string input,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}