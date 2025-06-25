//HintName: G.IApi.UpdateVoiceV1VoicesVoiceIdEditPost.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> UpdateVoiceV1VoicesVoiceIdEditPostAsync(
            string voiceId,
            global::G.BodyUpdateVoiceV1VoicesVoiceIdEditPost request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Voice
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> UpdateVoiceV1VoicesVoiceIdEditPostAsync(
            string voiceId,
            string name,
            string description,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}