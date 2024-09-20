//HintName: G.IParaphraseClient.V1Paraphraze.g.cs
#nullable enable

namespace G
{
    public partial interface IParaphraseClient
    {
        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V1ParaphrazeResponse> V1ParaphrazeAsync(
            global::G.ParaphraseBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Paraphrase
        /// </summary>
        /// <param name="text"></param>
        /// <param name="style">
        /// An enumeration.
        /// </param>
        /// <param name="startIndex">
        /// Default Value: 0
        /// </param>
        /// <param name="endIndex"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.V1ParaphrazeResponse> V1ParaphrazeAsync(
            string text,
            global::G.StyleType? style = default,
            int? startIndex = 0,
            int? endIndex = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}