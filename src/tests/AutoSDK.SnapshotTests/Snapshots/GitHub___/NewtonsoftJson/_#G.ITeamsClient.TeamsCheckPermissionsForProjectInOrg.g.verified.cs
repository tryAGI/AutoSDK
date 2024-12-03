//HintName: G.ITeamsClient.TeamsCheckPermissionsForProjectInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Check team permissions for a project<br/>
        /// Checks whether a team has `read`, `write`, or `admin` permissions for an organization project. The response includes projects inherited from a parent team.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/projects/{project_id}`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="projectId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::G.TeamProject> TeamsCheckPermissionsForProjectInOrgAsync(
            string org,
            string teamSlug,
            int projectId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}