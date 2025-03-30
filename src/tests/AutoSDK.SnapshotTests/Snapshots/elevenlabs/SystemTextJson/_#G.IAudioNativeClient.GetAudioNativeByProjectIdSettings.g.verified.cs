//HintName: G.IAudioNativeClient.GetAudioNativeByProjectIdSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioNativeClient
    {
        /// <summary>
        /// Get Audio Native Project Settings<br/>
        /// Get player settings for the specific project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.<br/>
        /// Example: 21m00Tcm4TlvDq8ikWAM
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAudioNativeProjectSettingsResponseModel> GetAudioNativeByProjectIdSettingsAsync(
            string projectId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}