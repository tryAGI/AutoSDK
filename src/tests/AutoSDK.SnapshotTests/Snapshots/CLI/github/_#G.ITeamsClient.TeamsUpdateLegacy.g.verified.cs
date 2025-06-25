//HintName: G.ITeamsClient.TeamsUpdateLegacy.g.cs
#nullable enable

namespace G
{
    public partial interface ITeamsClient
    {
        /// <summary>
        /// Update a team (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/teams/teams#update-a-team) endpoint.<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; With nested teams, the `privacy` for parent teams cannot be `secret`.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsUpdateLegacyAsync(
            int teamId,
            global::G.TeamsUpdateLegacyRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Update a team (Legacy)<br/>
        /// &gt; [!WARNING]<br/>
        /// &gt; **Deprecation notice:** This endpoint route is deprecated and will be removed from the Teams API. We recommend migrating your existing code to use the new [Update a team](https://docs.github.com/rest/teams/teams#update-a-team) endpoint.<br/>
        /// To edit a team, the authenticated user must either be an organization owner or a team maintainer.<br/>
        /// &gt; [!NOTE]<br/>
        /// &gt; With nested teams, the `privacy` for parent teams cannot be `secret`.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="name">
        /// The name of the team.
        /// </param>
        /// <param name="description">
        /// The description of the team.
        /// </param>
        /// <param name="privacy">
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </param>
        /// <param name="notificationSetting">
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
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
        [global::System.Obsolete("This method marked as deprecated.")]
        global::System.Threading.Tasks.Task<global::G.TeamFull> TeamsUpdateLegacyAsync(
            int teamId,
            string name,
            string? description = default,
            global::G.TeamsUpdateLegacyRequestPrivacy? privacy = default,
            global::G.TeamsUpdateLegacyRequestNotificationSetting? notificationSetting = default,
            global::G.TeamsUpdateLegacyRequestPermission? permission = default,
            int? parentTeamId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}