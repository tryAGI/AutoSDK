//HintName: G.IVoicesClient.GetVoiceV1VoicesVoiceIdGet.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Voice<br/>
        /// Returns metadata about a specific voice.
        /// </summary>
        /// <param name="voiceId">
        /// Voice ID to be used, you can use https://api.elevenlabs.io/v1/voices to list all the available voices.
        /// </param>
        /// <param name="withSettings">
        /// If set will return settings information corresponding to the voice, requires authorization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceResponseModel> GetVoiceV1VoicesVoiceIdGetAsync(
            string voiceId,
            bool? withSettings = false,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}