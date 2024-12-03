//HintName: G.IActionsClient.ActionsGetActionsCacheUsageForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IActionsClient
    {
        /// <summary>
        /// Get GitHub Actions cache usage for an organization<br/>
        /// Gets the total GitHub Actions cache usage for an organization.<br/>
        /// The data fetched using this API is refreshed approximately every 5 minutes, so values returned from this endpoint may take at least 5 minutes to get updated.<br/>
        /// OAuth tokens and personal access tokens (classic) need the `read:org` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.ActionsCacheUsageOrgEnterprise> ActionsGetActionsCacheUsageForOrgAsync(
            string org,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}