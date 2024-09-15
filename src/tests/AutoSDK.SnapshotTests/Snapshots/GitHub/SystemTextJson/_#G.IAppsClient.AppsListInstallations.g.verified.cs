//HintName: G.IAppsClient.AppsListInstallations.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// List installations for the authenticated app<br/>
        /// The permissions the installation has are included under the `permissions` key.<br/>
        /// You must use a [JWT](https://docs.github.com/apps/building-github-apps/authenticating-with-github-apps/#authenticating-as-a-github-app) to access this endpoint.
        /// </summary>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="since"></param>
        /// <param name="outdated"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.Installation>> AppsListInstallationsAsync(
            int perPage = 30,
            int page = 1,
            global::System.DateTime since = default,
            string? outdated = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}