//HintName: G.IAppsClient.AppsGetInstallation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get an installation for the authenticated app<br/>
        /// Enables an authenticated GitHub App to find an installation's information using the installation id.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Installation> AppsGetInstallationAsync(
            int installationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}