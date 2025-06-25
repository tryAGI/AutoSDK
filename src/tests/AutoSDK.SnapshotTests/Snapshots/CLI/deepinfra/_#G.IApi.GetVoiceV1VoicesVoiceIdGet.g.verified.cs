//HintName: G.IApi.GetVoiceV1VoicesVoiceIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Get Voice<br/>
        /// Get a voice by its id
        /// </summary>
        /// <param name="voiceId"></param>
        /// <param name="xiApiKey"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Voice> GetVoiceV1VoicesVoiceIdGetAsync(
            string voiceId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}