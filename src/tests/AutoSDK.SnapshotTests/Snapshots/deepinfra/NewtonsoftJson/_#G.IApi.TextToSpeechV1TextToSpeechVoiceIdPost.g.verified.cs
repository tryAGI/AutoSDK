//HintName: G.IApi.TextToSpeechV1TextToSpeechVoiceIdPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechV1TextToSpeechVoiceIdPostAsync(
            string voiceId,
            global::G.ElevenLabsTextToSpeechIn request,
            string? outputFormat = default,
            string? xDeepinfraSource = default,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Text To Speech
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="outputFormat"></param>
        /// <param name="xDeepinfraSource"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="text">
        /// Text to convert to speech<br/>
        /// Example: I'm beginnin' to feel like a Rap God, Rap God<br/>
        /// All my people from the front to the back nod, back nod<br/>
        /// Now, who thinks their arms are long enough to slap box, slap box?<br/>
        /// They said I rap like a robot, so call me Rap-bot
        /// </param>
        /// <param name="modelId">
        /// Model ID to use for the conversion<br/>
        /// Default Value: hexgrad/Kokoro-82M
        /// </param>
        /// <param name="requestOutputFormat">
        /// Select the desired format for the speech output. Supported formats include mp3, opus, flac, wav, and pcm.<br/>
        /// Default Value: wav<br/>
        /// Example: mp3
        /// </param>
        /// <param name="languageCode">
        /// ISO 639-1, 2 letter language code
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> TextToSpeechV1TextToSpeechVoiceIdPostAsync(
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