//HintName: G.ITeamsClient.TeamsListReposInOrg.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// List team repositories<br/>
        /// Lists a team's repositories visible to the authenticated user.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; You can also specify a team by `org_id` and `team_id` using the route `GET /organizations/{org_id}/team/{team_id}/repos`.
        /// </summary>
        /// <param name="org"></param>
        /// <param name="teamSlug"></param>
        /// <param name="perPage">
        /// Default Value: 30
        /// </param>
        /// <param name="page">
        /// Default Value: 1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.MinimalRepository>> TeamsListReposInOrgAsync(
            string org,
            string teamSlug,
            int? perPage = default,
            int? page = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}