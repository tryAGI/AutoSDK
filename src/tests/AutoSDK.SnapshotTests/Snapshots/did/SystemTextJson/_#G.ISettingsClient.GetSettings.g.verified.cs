//HintName: G.ISettingsClient.GetSettings.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Get user settings
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetSettingsResponse2> GetSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}