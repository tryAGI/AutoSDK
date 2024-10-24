//HintName: G.ICompletionClient.V1J2MidCustomModelComplete.g.cs
#nullable enable

namespace G
{
    public partial interface ICompletionClient
    {
        /// <summary>
        /// Custom j2-mid complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-mid
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1J2MidCustomModelCompleteAsync(
            string customModelName,
            global::G.CompletionBody request,
            string? customModelType = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Custom j2-mid complete
        /// </summary>
        /// <param name="customModelName"></param>
        /// <param name="customModelType">
        /// Default Value: j2-mid
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 16
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="temperature">
        /// Default Value: 1
        /// </param>
        /// <param name="topP">
        /// Default Value: 1
        /// </param>
        /// <param name="minP">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences"></param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="logitBias"></param>
        /// <param name="frequencyPenalty"></param>
        /// <param name="presencePenalty"></param>
        /// <param name="countPenalty"></param>
        /// <param name="epoch"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> V1J2MidCustomModelCompleteAsync(
            string customModelName,
            string prompt,
            string? customModelType = default,
            int? numResults = default,
            int? maxTokens = default,
            int? minTokens = default,
            double? temperature = default,
            double? topP = default,
            double? minP = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            int? topKReturn = default,
            object? logitBias = default,
            global::G.Penalty? frequencyPenalty = default,
            global::G.Penalty? presencePenalty = default,
            global::G.Penalty? countPenalty = default,
            int? epoch = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}