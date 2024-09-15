//HintName: G.IGrammaticalErrorCorrectionsClient.V1Corrections.g.cs
#nullable enable

namespace G
{
    public partial interface IGrammaticalErrorCorrectionsClient
    {
        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CorrectionsResponse> V1CorrectionsAsync(
            global::G.CorrectionsBody request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Grammatical Error Corrections
        /// </summary>
        /// <param name="text"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CorrectionsResponse> V1CorrectionsAsync(
            string text,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}