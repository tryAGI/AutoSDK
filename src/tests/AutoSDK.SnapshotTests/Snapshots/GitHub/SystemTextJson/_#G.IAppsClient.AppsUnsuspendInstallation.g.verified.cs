//HintName: G.IAppsClient.AppsUnsuspendInstallation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Unsuspend an app installation<br/>
        /// Removes a GitHub App installation suspension.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="installationId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AppsUnsuspendInstallationAsync(
            int installationId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}