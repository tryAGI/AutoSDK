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
        /// One of the [available TTS models](/docs/text-to-speech).<br/>
        /// Example: playai-tts
        /// </param>
        /// <param name="input">
        /// The text to generate audio for.<br/>
        /// Example: The quick brown fox jumped over the lazy dog
        /// </param>
        /// <param name="voice">
        /// The voice to use when generating the audio. List of voices can be found [here](/docs/text-to-speech).<br/>
        /// Example: Fritz-PlayAI
        /// </param>
        /// <param name="responseFormat">
        /// The format of the generated audio. Supported formats are `flac, mp3, mulaw, ogg, wav`.<br/>
        /// Default Value: mp3
        /// </param>
        /// <param name="sampleRate">
        /// The sample rate for generated audio<br/>
        /// Default Value: 48000<br/>
        /// Example: 48000
        /// </param>
        /// <param name="speed">
        /// The speed of the generated audio.<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> CreateSpeechAsync(
            global::G.AnyOf<string, global::G.CreateSpeechRequestModel?> model,
            string input,
            string voice,
            global::G.CreateSpeechRequestResponseFormat? responseFormat = default,
            int? sampleRate = default,
            double? speed = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}