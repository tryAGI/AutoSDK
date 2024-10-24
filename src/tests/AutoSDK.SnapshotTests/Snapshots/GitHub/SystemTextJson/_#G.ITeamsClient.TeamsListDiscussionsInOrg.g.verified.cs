//HintName: G.ITeamsClient.TeamsListDiscussionsInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List discussions<br/>
        /// List all discussions on a team's page.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/discussions`.<br/>
        /// OAuth app tokens and personal access tokens (classic) need the `read:discussion` scope to use this endpoint.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="direction">
        /// Default Value: desc
        /// </param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="pinned"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.TeamDiscussion>> TeamsListDiscussionsInOrgAsync(
            string org,
            string teamSlug,
            global::G.TeamsListDiscussionsInOrgDirection? direction = default,
            int? perPage = default,
            int? page = default,
            string? pinned = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}