//HintName: G.IDependabotClient.DependabotListAlertsForOrg.g.cs
#nullable enable

namespace G
{
    public partial interface IDependabotClient
    {
        /// <summary>
        /// List Dependabot alerts for an organization<br/>
        /// Lists Dependabot alerts for an organization.<br/>
        /// The authenticated user must be an owner or security manager for the organization to use this endpoint.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `security_events` scope to use this endpoint. If this endpoint is only used with public repositories, the token can use the `public_repo` scope instead.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="state"></param>
        /// <param name="severity"></param>
        /// <param name="ecosystem"></param>
        /// <param name="package"></param>
        /// <param name="scope"></param>
        /// <param name="sort">
        /// Default Value: created
        /// </param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <param name="first">
        /// Default Value: 30
        /// </param>
        /// <param name="last"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.DependabotAlertWithRepository>> DependabotListAlertsForOrgAsync(
            string org,
            string? state = default,
            string? severity = default,
            string? ecosystem = default,
            string? package = default,
            global::G.DependabotListAlertsForOrgScope? scope = default,
            global::G.DependabotListAlertsForOrgSort? sort = global::G.DependabotListAlertsForOrgSort.Created,
            global::G.DependabotListAlertsForOrgDirection? direction = global::G.DependabotListAlertsForOrgDirection.Desc,
            string? before = default,
            string? after = default,
            int? first = 30,
            int? last = default,
            int? perPage = 30,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}