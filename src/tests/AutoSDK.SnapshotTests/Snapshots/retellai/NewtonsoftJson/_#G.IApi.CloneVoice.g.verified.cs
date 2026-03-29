//HintName: G.IApi.CloneVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponse> CloneVoiceAsync(

            global::G.CloneVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clone a voice from audio files
        /// </summary>
        /// <param name="files">
        /// Audio files to use for voice cloning. Up to 25 files allowed. For Cartesia and MiniMax, only 1 file is supported. For Inworld, up to 3 files are supported.
        /// </param>
        /// <param name="voiceName">
        /// Name for the cloned voice
        /// </param>
        /// <param name="voiceProvider">
        /// Voice provider to use for cloning.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponse> CloneVoiceAsync(
            global::System.Collections.Generic.IList<byte[]> files,
            string voiceName,
            global::G.CloneVoiceRequestVoiceProvider voiceProvider,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}