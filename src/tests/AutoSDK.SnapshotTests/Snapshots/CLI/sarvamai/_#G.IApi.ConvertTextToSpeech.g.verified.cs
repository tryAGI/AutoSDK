//HintName: G.IApi.ConvertTextToSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Convert text to speech<br/>
        /// Converts text to natural speech using the Bulbul model.<br/>
        /// Supports 10 Indian languages plus English with 30+ speaker voices.<br/>
        /// Max 2500 characters per request (v3).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToSpeechResponse> ConvertTextToSpeechAsync(

            global::G.TextToSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Convert text to speech<br/>
        /// Converts text to natural speech using the Bulbul model.<br/>
        /// Supports 10 Indian languages plus English with 30+ speaker voices.<br/>
        /// Max 2500 characters per request (v3).
        /// </summary>
        /// <param name="text">
        /// Text to convert to speech (max 2500 chars for v3, 1500 for v2). Supports code-mixed text.
        /// </param>
        /// <param name="targetLanguageCode">
        /// Language code (BCP-47) for text normalization
        /// </param>
        /// <param name="model">
        /// TTS model to use<br/>
        /// Default Value: bulbul:v3
        /// </param>
        /// <param name="speaker">
        /// Speaker voice (default: shubh for v3, anushka for v2)
        /// </param>
        /// <param name="pitch">
        /// Pitch adjustment (-0.75 to 0.75). v2 only.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="pace">
        /// Speech speed (v3: 0.5-2.0, v2: 0.3-3.0)<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="loudness">
        /// Loudness (0.3-3.0). v2 only.<br/>
        /// Default Value: 1.0
        /// </param>
        /// <param name="temperature">
        /// Randomness/expressiveness (0.01-2.0). v3 only.<br/>
        /// Default Value: 0.6
        /// </param>
        /// <param name="speechSampleRate">
        /// Audio sample rate in Hz<br/>
        /// Default Value: 24000
        /// </param>
        /// <param name="outputAudioCodec">
        /// Output audio format
        /// </param>
        /// <param name="enablePreprocessing">
        /// Enable preprocessing. v2 only.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="dictId">
        /// Custom pronunciation dictionary ID. v3 only.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TextToSpeechResponse> ConvertTextToSpeechAsync(
            string text,
            global::G.TextToSpeechRequestTargetLanguageCode targetLanguageCode,
            global::G.TextToSpeechRequestModel? model = default,
            global::G.TextToSpeechRequestSpeaker? speaker = default,
            double? pitch = default,
            double? pace = default,
            double? loudness = default,
            double? temperature = default,
            global::G.TextToSpeechRequestSpeechSampleRate? speechSampleRate = default,
            global::G.TextToSpeechRequestOutputAudioCodec? outputAudioCodec = default,
            bool? enablePreprocessing = default,
            string? dictId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}