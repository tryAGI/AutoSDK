//HintName: G.ITeamsClient.TeamsGetMemberLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Get team member (Legacy)<br/>
        /// The "Get team member" endpoint (described below) is deprecated.<br/>
        /// We recommend using the [Get team membership for a user](https://docs.github.com/rest/teams/members#get-team-membership-for-a-user) endpoint instead. It allows you to get both active and pending memberships.<br/>
        /// To list members in a team, the team must be visible to the authenticated user.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="username"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task TeamsGetMemberLegacyAsync(
            int teamId,
            string username,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}