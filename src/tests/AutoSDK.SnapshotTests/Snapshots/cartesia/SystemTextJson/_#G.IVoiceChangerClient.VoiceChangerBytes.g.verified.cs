//HintName: G.IVoiceChangerClient.VoiceChangerBytes.g.cs
#nullable enable

namespace G
{
    public partial interface IVoiceChangerClient
    {
        /// <summary>
        /// Voice Changer (Bytes)<br/>
        /// Takes an audio file of speech, and returns an audio file of speech spoken with the same intonation, but with a different voice.<br/>
        /// This endpoint is priced at 15 characters per second of input audio.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VoiceChangerBytesAsync(
            global::G.VoiceChangerBytesCartesiaVersion cartesiaVersion,

            global::G.VoiceChangerBytesRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Voice Changer (Bytes)<br/>
        /// Takes an audio file of speech, and returns an audio file of speech spoken with the same intonation, but with a different voice.<br/>
        /// This endpoint is priced at 15 characters per second of input audio.
        /// </summary>
        /// <param name="cartesiaVersion">
        /// Example: 2025-04-16
        /// </param>
        /// <param name="clip"></param>
        /// <param name="clipname"></param>
        /// <param name="voiceId"></param>
        /// <param name="outputFormatContainer"></param>
        /// <param name="outputFormatSampleRate"></param>
        /// <param name="outputFormatEncoding"></param>
        /// <param name="outputFormatBitRate">
        /// Required for `mp3` containers.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<byte[]> VoiceChangerBytesAsync(
            global::G.VoiceChangerBytesCartesiaVersion cartesiaVersion,
            byte[]? clip = default,
            string? clipname = default,
            string? voiceId = default,
            global::G.OutputFormatContainer? outputFormatContainer = default,
            int? outputFormatSampleRate = default,
            global::G.RawEncoding? outputFormatEncoding = default,
            int? outputFormatBitRate = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}