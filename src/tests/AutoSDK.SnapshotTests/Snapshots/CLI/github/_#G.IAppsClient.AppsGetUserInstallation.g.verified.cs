//HintName: G.IAppsClient.AppsGetUserInstallation.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Get a user installation for the authenticated app<br/>
        /// Enables an authenticated GitHub App to find the user’s installation information.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.Installation> AppsGetUserInstallationAsync(
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}