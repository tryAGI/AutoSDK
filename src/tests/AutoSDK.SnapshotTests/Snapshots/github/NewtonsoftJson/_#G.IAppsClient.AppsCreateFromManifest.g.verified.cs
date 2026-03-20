//HintName: G.IAppsClient.AppsCreateFromManifest.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Create a GitHub App from a manifest<br/>
        /// Use this endpoint to complete the handshake necessary when implementing the [GitHub App Manifest flow](https://docs.github.com/apps/building-github-apps/creating-github-apps-from-a-manifest/). When you create a GitHub App with the manifest flow, you receive a temporary `code` used to retrieve the GitHub App's `id`, `pem` (private key), and `webhook_secret`.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.AllOf<global::G.Integration, global::G.AppsCreateFromManifestResponse2>> AppsCreateFromManifestAsync(
            string code,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}