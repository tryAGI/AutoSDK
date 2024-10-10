//HintName: G.IVoicesClient.GetDefaultVoiceSettingsV1VoicesSettingsDefaultGet.g.cs
#nullable enable

namespace G
{
    public partial interface IVoicesClient
    {
        /// <summary>
        /// Get Default Voice Settings.<br/>
        /// Gets the default settings for voices. "similarity_boost" corresponds to"Clarity + Similarity Enhancement" in the web app and "stability" corresponds to "Stability" slider in the web app.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.VoiceSettingsResponseModel> GetDefaultVoiceSettingsV1VoicesSettingsDefaultGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}