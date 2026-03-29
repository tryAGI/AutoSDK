//HintName: G.IProjectsClient.GetOrgProjectConfig.g.cs
#nullable enable

namespace G
{
    public partial interface IProjectsClient
    {
        /// <summary>
        /// Get project configuration<br/>
        /// Retrieves the current project configuration including 2FA settings.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.GetOrgProjectConfigResponse> GetOrgProjectConfigAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}