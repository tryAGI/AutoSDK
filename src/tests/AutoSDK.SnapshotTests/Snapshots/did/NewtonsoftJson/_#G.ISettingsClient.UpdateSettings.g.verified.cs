//HintName: G.ISettingsClient.UpdateSettings.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Update settings
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateSettingsResponse> UpdateSettingsAsync(

            global::G.UpdateSettingsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update settings
        /// </summary>
        /// <param name="agentsInsightsIsEnabled"></param>
        /// <param name="logo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.UpdateSettingsResponse> UpdateSettingsAsync(
            bool? agentsInsightsIsEnabled = default,
            global::G.UpdateSettingsRequestLogo? logo = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}