//HintName: G.IAppClient.AppPublicServiceListApps.g.cs
#nullable enable

namespace G
{
    public partial interface IAppClient
    {
        /// <summary>
        /// List all apps info<br/>
        /// Returns a paginated list of apps.
        /// </summary>
        /// <param name="namespaceId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ListAppsResponse> AppPublicServiceListAppsAsync(
            string namespaceId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}