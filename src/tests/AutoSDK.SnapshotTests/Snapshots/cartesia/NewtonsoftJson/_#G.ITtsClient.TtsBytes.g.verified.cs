//HintName: G.ITtsClient.TtsBytes.g.cs
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace G
{
    public partial interface ITtsClient
    {
        /// <summary>
        /// Text to Speech (Bytes)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> TtsBytesAsync(
            global::G.TtsBytesCartesiaVersion cartesiaVersion,

            global::G.TTSRequest request,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Text to Speech (Bytes)
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="modelId">
        /// The ID of the model to use for the generation. See [Models](/build-with-cartesia/tts-models) for available models.
        /// </param>
        /// <param name="transcript"></param>
        /// <param name="voice"></param>
        /// <param name="language">
        /// The language that the given voice should speak the transcript in. For valid options, see [Models](/build-with-cartesia/tts-models).
        /// </param>
        /// <param name="generationConfig">
        /// Configure the various attributes of the generated speech. These are only for `sonic-3` and have no effect on earlier models.<br/>
        /// See [Volume, Speed, and Emotion in Sonic-3](/build-with-cartesia/sonic-3/volume-speed-emotion) for a guide on this option.
        /// </param>
        /// <param name="outputFormat"></param>
        /// <param name="save">
        /// Whether to save the generated audio file. When true, the response will include a `Cartesia-File-ID` header.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="pronunciationDictId">
        /// The ID of a pronunciation dictionary to use for the generation. Pronunciation dictionaries are supported by `sonic-3` models and newer.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> TtsBytesAsync(
            global::G.TtsBytesCartesiaVersion cartesiaVersion,
            string modelId,
            string transcript,
            global::G.TTSRequestVoiceSpecifier voice,
            global::G.OutputFormat outputFormat,
            global::G.SupportedLanguage? language = default,
            global::G.GenerationConfig? generationConfig = default,
            bool? save = default,
            string? pronunciationDictId = default,
            global::G.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}