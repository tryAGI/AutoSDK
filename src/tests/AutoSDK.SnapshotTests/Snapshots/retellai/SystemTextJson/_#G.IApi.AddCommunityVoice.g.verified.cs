//HintName: G.IApi.AddCommunityVoice.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Add a community voice to the voice library
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponse> AddCommunityVoiceAsync(

            global::G.AddCommunityVoiceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Add a community voice to the voice library
        /// </summary>
        /// <param name="voiceProvider">
        /// Voice provider to add the voice from.
        /// </param>
        /// <param name="providerVoiceId">
        /// Voice id assigned by the provider.
        /// </param>
        /// <param name="voiceName">
        /// A custom name for the voice.
        /// </param>
        /// <param name="publicUserId">
        /// Required for ElevenLabs only. User id of the voice owner.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponse> AddCommunityVoiceAsync(
            string providerVoiceId,
            string voiceName,
            global::G.AddCommunityVoiceRequestVoiceProvider? voiceProvider = default,
            string? publicUserId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}