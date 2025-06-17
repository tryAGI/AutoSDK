//HintName: G.IConversationalAIClient.EditConvaiSettingsDashboard.g.cs
#nullable enable

namespace G
{
    public partial interface IConversationalAIClient
    {
        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConvAIDashboardSettingsResponseModel> EditConvaiSettingsDashboardAsync(
            global::G.PatchConvAIDashboardSettingsRequest request,
            string? xiApiKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update Convai Dashboard Settings<br/>
        /// Update Convai dashboard settings for the workspace
        /// </summary>
        /// <param name="xiApiKey">
        /// Your API key. This is required by most endpoints to access our API programatically. You can view your xi-api-key using the 'Profile' tab on the website.
        /// </param>
        /// <param name="charts"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetConvAIDashboardSettingsResponseModel> EditConvaiSettingsDashboardAsync(
            string? xiApiKey = default,
            global::System.Collections.Generic.IList<global::G.ChartsItem2>? charts = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}