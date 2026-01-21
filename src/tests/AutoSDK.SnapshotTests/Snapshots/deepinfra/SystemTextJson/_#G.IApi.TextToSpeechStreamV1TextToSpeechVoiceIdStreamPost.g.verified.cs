//HintName: G.IApi.TextToSpeechStreamV1TextToSpeechVoiceIdStreamPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Text To Speech Stream
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostAsync(
            string voiceId,
            global::G.ElevenLabsTextToSpeechIn request,
            string? outputFormat = default,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Text To Speech Stream
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="text">
        /// Text to convert to speech
        /// </param>
        /// <param name="modelId">
        /// Model ID to use for the conversion<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </param>
        /// <param name="requestOutputFormat">
        /// Output format for the speech<br/>
        /// Default Value: wav
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1, 2 letter language code
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechStreamV1TextToSpeechVoiceIdStreamPostAsync(
            string voiceId,
            string text,
            string? outputFormat = default,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            string? modelId = default,
            global::G.TtsResponseFormat? requestOutputFormat = default,
            string? languageCode = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}