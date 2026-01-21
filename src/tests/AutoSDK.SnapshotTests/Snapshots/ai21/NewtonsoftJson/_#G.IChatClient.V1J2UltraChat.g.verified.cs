//HintName: G.IChatClient.V1J2UltraChat.g.cs
#nullable enable

namespace G
{
    public partial interface IChatClient
    {
        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> V1J2UltraChatAsync(
            global::G.LanguageStudioApiServerDataTypesJ2ChatChatRequest request,
            string? model = default,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// j2-ultra chat
        /// </summary>
        /// <param name="model">
        /// Default Value: j2-ultra
        /// </param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008L
        /// </param>
        /// <param name="messages">
        /// messages
        /// </param>
        /// <param name="system"></param>
        /// <param name="frequencyPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="presencePenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="countPenalty">
        /// Default Value: {"scale":0.0,"applyToWhitespaces":true,"applyToPunctuations":true,"applyToNumbers":true,"applyToStopwords":true,"applyToEmojis":true}
        /// </param>
        /// <param name="numResults">
        /// Default Value: 1
        /// </param>
        /// <param name="temperature">
        /// Default Value: 0.7F
        /// </param>
        /// <param name="maxTokens">
        /// Default Value: 300
        /// </param>
        /// <param name="minTokens">
        /// Default Value: 0
        /// </param>
        /// <param name="topP">
        /// Default Value: 1F
        /// </param>
        /// <param name="topKReturn">
        /// Default Value: 0
        /// </param>
        /// <param name="stopSequences">
        /// Default Value: []
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.ChatResponse> V1J2UltraChatAsync(
            global::System.Collections.Generic.IList<global::G.ChatMessage> messages,
            string system,
            string? model = default,
            int? requestStartTime = default,
            global::G.Penalty? frequencyPenalty = default,
            global::G.Penalty? presencePenalty = default,
            global::G.Penalty? countPenalty = default,
            int? numResults = default,
            double? temperature = default,
            int? maxTokens = default,
            int? minTokens = default,
            double? topP = default,
            int? topKReturn = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}