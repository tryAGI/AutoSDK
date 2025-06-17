//HintName: G.IApi.Detokenize.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Detokenize<br/>
        /// This endpoint takes tokens using byte-pair encoding and returns their text representation. To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetokenizeResponse> DetokenizeAsync(
            global::G.DetokenizeRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Detokenize<br/>
        /// This endpoint takes tokens using byte-pair encoding and returns their text representation. To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// An optional parameter to provide the model name. This will ensure that the detokenization is done by the tokenizer used by that model.
        /// </param>
        /// <param name="tokens">
        /// The list of tokens to be detokenized.<br/>
        /// Included only in requests
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetokenizeResponse> DetokenizeAsync(
            string model,
            global::System.Collections.Generic.IList<int> tokens,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}