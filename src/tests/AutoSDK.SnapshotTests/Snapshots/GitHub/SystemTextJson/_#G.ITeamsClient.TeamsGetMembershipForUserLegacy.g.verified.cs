//HintName: G.ITeamsClient.TeamsGetMembershipForUserLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Get team membership for a user (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Get team membership for a user](https://docs.github.com/rest/teams/members#get-team-membership-for-a-user) endpoint.<br/>
        /// Team members will include the members of child teams.<br/>
        /// To get a user's membership with a team, the team must be visible to the authenticated user.<br/>
        /// **Note:**<br/>
        /// The response contains the `state` of the membership and the member's `role`.<br/>
        /// The `role` for organization owners is set to `maintainer`. For more information about `maintainer` roles, see [Create a team](https://docs.github.com/rest/teams/teams#create-a-team).
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamMembership> TeamsGetMembershipForUserLegacyAsync(
            int teamId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}