//HintName: G.ISpeechClient.TranscribeOrTranslate.g.cs
#nullable enable

namespace G
{
    public partial interface ISpeechClient
    {
        /// <summary>
        /// Transcribe or translate audio<br/>
        /// Transcribes audio to text and optionally translates it to a target language.<br/>
        /// Supports three modes: transcription only, translation (text output), and<br/>
        /// speech-to-speech translation (with audio output).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscribeOrTranslateResponse> TranscribeOrTranslateAsync(

            global::G.TranscribeOrTranslateRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Transcribe or translate audio<br/>
        /// Transcribes audio to text and optionally translates it to a target language.<br/>
        /// Supports three modes: transcription only, translation (text output), and<br/>
        /// speech-to-speech translation (with audio output).
        /// </summary>
        /// <param name="audioUrl">
        /// URL to a WAV audio file (http/https) or a base64-encoded data URI (data:audio/wav;base64,...).
        /// </param>
        /// <param name="samplingRate">
        /// Audio sampling rate in Hz. Recommended value is 16000.<br/>
        /// Default Value: 16000
        /// </param>
        /// <param name="targetLanguage">
        /// Target language for translation. When omitted, only transcription is performed.
        /// </param>
        /// <param name="isTranslate">
        /// Set to true to indicate this is a translation request. Must be true when target_language is specified.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="returnTranslationAudio">
        /// Set to true to receive base64-encoded WAV audio of the translated speech. Requires is_translate and target_language.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="temperature">
        /// Controls randomness in generation. Use 0.0 for deterministic output.<br/>
        /// Default Value: 0.0
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate.<br/>
        /// Default Value: 1024
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TranscribeOrTranslateResponse> TranscribeOrTranslateAsync(
            string audioUrl,
            int samplingRate,
            global::G.TranscribeOrTranslateRequestTargetLanguage? targetLanguage = default,
            bool? isTranslate = default,
            bool? returnTranslationAudio = default,
            double? temperature = default,
            int? maxTokens = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}