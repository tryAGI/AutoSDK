//HintName: G.IAudioClient.CreateSpeech.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioClient
    {
        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::G.CreateSpeechRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Generates audio from the input text.
        /// </summary>
        /// <param name="model">
        /// One of the available [TTS models](/docs/models#tts): `tts-1` or `tts-1-hd`
        /// </param>
        /// <param name="input">
        /// The text to generate audio for. The maximum length is 4096 characters.
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. Supported voices are `alloy`, `echo`, `fable`, `onyx`, `nova`, and `shimmer`. Previews of the voices are available in the [Text to speech guide](/docs/guides/text-to-speech#voice-options).
        /// </param>
        /// <param name="responseFormat">
        /// The format to audio in. Supported formats are `mp3`, `opus`, `aac`, `flac`, `wav`, and `pcm`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio. Select a value from `0.25` to `4.0`. `1.0` is the default.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            global::G.CreateSpeechRequestVoice voice,
            global::G.CreateSpeechRequestResponseFormat? responseFormat = default,
            double? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}