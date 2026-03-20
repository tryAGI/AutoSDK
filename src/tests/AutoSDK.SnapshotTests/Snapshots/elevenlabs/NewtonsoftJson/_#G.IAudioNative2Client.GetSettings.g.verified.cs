//HintName: G.IAudioNative2Client.GetSettings.g.cs
#nullable enable

namespace G
{
    public partial interface IAudioNative2Client
    {
        /// <summary>
        /// Get Audio Native Project Settings<br/>
        /// Get player settings for the specific project.
        /// </summary>
        /// <param name="projectId">
        /// The ID of the Studio project.
        /// </param>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programmatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetAudioNativeProjectSettingsResponseModel> GetSettingsAsync(
            string projectId,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}