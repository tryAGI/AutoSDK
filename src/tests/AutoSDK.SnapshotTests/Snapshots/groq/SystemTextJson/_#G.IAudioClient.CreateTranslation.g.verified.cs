//HintName: G.IAudioClient.CreateTranslation.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Translates audio into English.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTranslationResponseJson> CreateTranslationAsync(

            global::G.CreateTranslationRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Translates audio into English.
        /// </summary>
        /// <param name="file">
        /// The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="filename">
        /// The audio file object (not file name) translate, in one of these formats: flac, mp3, mp4, mpeg, mpga, m4a, ogg, wav, or webm.
        /// </param>
        /// <param name="url">
        /// The audio URL to translate/transcribe (supports Base64URL). Either file or url must be provided.<br/>
        /// When using the Batch API only url is supported.
        /// </param>
        /// <param name="model">
        /// ID of the model to use. `whisper-large-v3` and `whisper-large-v3-turbo` are currently available.<br/>
        /// Example: whisper-large-v3-turbo
        /// </param>
        /// <param name="prompt">
        /// An optional text to guide the model's style or continue a previous audio segment. The [prompt](/docs/guides/speech-to-text/prompting) should be in English.
        /// </param>
        /// <param name="responseFormat">
        /// The format of the transcript output, in one of these options: `json`, `text`, or `verbose_json`.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="temperature">
        /// The sampling temperature, between 0 and 1. Higher values like 0.8 will make the output more random, while lower values like 0.2 will make it more focused and deterministic. If set to 0, the model will use [log probability](https://en.wikipedia.org/wiki/Log_probability) to automatically increase the temperature until certain thresholds are hit.<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.CreateTranslationResponseJson> CreateTranslationAsync(
            global::G.AnyOf<string, global::G.CreateTranslationRequestModel?> model,
            byte[]? file = default,
            string? filename = default,
            string? url = default,
            string? prompt = default,
            global::G.CreateTranslationRequestResponseFormat? responseFormat = default,
            double? temperature = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}