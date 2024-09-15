//HintName: G.IAppsClient.AppsRevokeInstallationAccessToken.g.cs
#nullable enable

namespace G
{
    public partial interface IAppsClient
    {
        /// <summary>
        /// Revoke an installation access token<br/>
        /// Revokes the installation token you're using to authenticate as an installation and access this endpoint.<br/>
        /// Once an installation token is revoked, the token is invalidated and cannot be used. Other endpoints that require the revoked installation token must have a new installation token to work. You can create a new token using the "[Create an installation access token for an app](https://docs.github.com/rest/apps/apps#create-an-installation-access-token-for-an-app)" endpoint.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task AppsRevokeInstallationAccessTokenAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}