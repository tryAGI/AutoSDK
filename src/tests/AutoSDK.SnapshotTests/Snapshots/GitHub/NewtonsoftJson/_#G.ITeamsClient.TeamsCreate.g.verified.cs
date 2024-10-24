//HintName: G.ITeamsClient.TeamsCreate.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Create a team<br/>
        /// To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see "[Setting team creation permissions](https://docs.github.com/articles/setting-team-creation-permissions-in-your-organization)."<br/>
        /// When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see "[About teams](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/about-teams)".
        /// </summary>
        /// <param name="org"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsCreateAsync(
            string org,
            global::G.TeamsCreateRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Create a team<br/>
        /// To create a team, the authenticated user must be a member or owner of `{org}`. By default, organization members can create teams. Organization owners can limit team creation to organization owners. For more information, see "[Setting team creation permissions](https://docs.github.com/articles/setting-team-creation-permissions-in-your-organization)."<br/>
        /// When you create a new team, you automatically become a team maintainer without explicitly adding yourself to the optional array of `maintainers`. For more information, see "[About teams](https://docs.github.com/github/setting-up-and-managing-organizations-and-teams/about-teams)".
        /// </summary>
        /// <param name="org"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="maintainers">
        /// List GitHub IDs for organization members who will become team maintainers.
        /// </param>
        /// <param name="repoNames">
        /// The full name (e.g., "organization-name/repository-name") of repositories to add the team to.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default: `secret`  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default for child team: `closed`
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. The options are:  <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.  <br/>
        /// Default: `notifications_enabled`
        /// </param>
        /// <param name="permission">
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </param>
        /// <param name="parentTeamId">
        /// The ID of a team to set as the parent team.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsCreateAsync(
            string org,
            string name,
            string? description = default,
            global::System.Collections.Generic.IList<string>? maintainers = default,
            global::System.Collections.Generic.IList<string>? repoNames = default,
            global::G.TeamsCreateRequestPrivacy? privacy = default,
            global::G.TeamsCreateRequestNotificationSetting? notificationSetting = default,
            global::G.TeamsCreateRequestPermission? permission = default,
            int? parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}