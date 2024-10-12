//HintName: G.ITokenizeClient.V1Tokenize.g.cs
#nullable enable

namespace G
{
    public partial interface ITokenizeClient
    {
        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1TokenizeAsync(
            global::G.TokenizeBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Tokenize
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1TokenizeAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}