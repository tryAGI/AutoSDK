//HintName: G.IApi.Tokenize.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Tokenize<br/>
        /// This endpoint splits input text into smaller units called tokens using byte-pair encoding (BPE). To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenizeResponse> TokenizeAsync(
            global::G.TokenizeRequest request,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Tokenize<br/>
        /// This endpoint splits input text into smaller units called tokens using byte-pair encoding (BPE). To learn more about tokenization and byte pair encoding, see the tokens page.
        /// </summary>
        /// <param name="xClientName"></param>
        /// <param name="model">
        /// The input will be tokenized by the tokenizer that is used by this model.
        /// </param>
        /// <param name="text">
        /// The string to be tokenized, the minimum text length is 1 character, and the maximum text length is 65536 characters.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TokenizeResponse> TokenizeAsync(
            string model,
            string text,
            string? xClientName = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}