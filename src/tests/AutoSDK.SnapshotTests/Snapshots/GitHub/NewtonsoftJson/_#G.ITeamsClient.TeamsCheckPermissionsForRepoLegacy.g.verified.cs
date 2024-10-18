//HintName: G.ITeamsClient.TeamsCheckPermissionsForRepoLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Check team permissions for a repository (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Check team permissions for a repository](https://docs.github.com/rest/teams/teams#check-team-permissions-for-a-repository) endpoint.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; Repositories inherited through a parent team will also be checked.<br/>
        /// You can also get information about the specified repository, including what permissions the team grants on it, by passing the following custom [media type](https://docs.github.com/rest/using-the-rest-api/getting-started-with-the-rest-api#media-types/) via the `Accept` header:
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="owner"></param>
        /// <param name="repo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamRepository> TeamsCheckPermissionsForRepoLegacyAsync(
            int teamId,
            string owner,
            string repo,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}