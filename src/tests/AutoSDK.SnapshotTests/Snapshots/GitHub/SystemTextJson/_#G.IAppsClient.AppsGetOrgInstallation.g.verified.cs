//HintName: G.IAppsClient.AppsGetOrgInstallation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get an organization installation for the authenticated app<br/>
        /// Enables an authenticated GitHub App to find the organization's installation information.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Installation> AppsGetOrgInstallationAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}