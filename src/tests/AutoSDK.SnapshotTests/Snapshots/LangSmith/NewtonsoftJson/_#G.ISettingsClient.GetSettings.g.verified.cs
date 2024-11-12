//HintName: G.ISettingsClient.GetSettings.g.cs
#nullable enable

namespace G
{
    public partial interface ISettingsClient
    {
        /// <summary>
        /// Get Settings<br/>
        /// Get settings.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AppHubCrudTenantsTenant> GetSettingsAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}