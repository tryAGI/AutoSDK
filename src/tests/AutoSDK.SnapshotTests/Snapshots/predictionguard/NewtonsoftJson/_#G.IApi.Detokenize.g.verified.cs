//HintName: G.IApi.Detokenize.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Detokenize<br/>
        /// Generates text from tokens using a model's tokenizer.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetokenizeResponse200> DetokenizeAsync(

            global::G.DetokenizeRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Detokenize<br/>
        /// Generates text from tokens using a model's tokenizer.
        /// </summary>
        /// <param name="model">
        /// The name of the model to use for detokenization.
        /// </param>
        /// <param name="tokens">
        /// The tokens to turn into text.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.DetokenizeResponse200> DetokenizeAsync(
            string model,
            global::System.Collections.Generic.IList<int> tokens,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}