//HintName: G.ITeamsClient.TeamsDeleteInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Delete a team<br/>
        /// To delete a team, the authenticated user must be an organization owner or team maintainer.<br/>
        /// If you are an organization owner, deleting a parent team will delete all of its child teams as well.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `DELETE /organizations/{org_id}/team/{team_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task TeamsDeleteInOrgAsync(
            string org,
            string teamSlug,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}