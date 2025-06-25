//HintName: G.Models.TeamsCreateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsCreateRequest
    {
        /// <summary>
        /// The name of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List GitHub IDs for organization members who will become team maintainers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maintainers")]
        public global::System.Collections.Generic.IList<string>? Maintainers { get; set; }

        /// <summary>
        /// The full name (e.g., "organization-name/repository-name") of repositories to add the team to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("repo_names")]
        public global::System.Collections.Generic.IList<string>? RepoNames { get; set; }

        /// <summary>
        /// The level of privacy this team should have. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default: `secret`  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// Default for child team: `closed`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamsCreateRequestPrivacyJsonConverter))]
        public global::G.TeamsCreateRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. The options are:  <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.  <br/>
        /// Default: `notifications_enabled`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamsCreateRequestNotificationSettingJsonConverter))]
        public global::G.TeamsCreateRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.TeamsCreateRequestPermissionJsonConverter))]
        public global::G.TeamsCreateRequestPermission? Permission { get; set; }

        /// <summary>
        /// The ID of a team to set as the parent team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_team_id")]
        public int? ParentTeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TeamsCreateRequest(
            string name,
            string? description,
            global::System.Collections.Generic.IList<string>? maintainers,
            global::System.Collections.Generic.IList<string>? repoNames,
            global::G.TeamsCreateRequestPrivacy? privacy,
            global::G.TeamsCreateRequestNotificationSetting? notificationSetting,
            global::G.TeamsCreateRequestPermission? permission,
            int? parentTeamId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Maintainers = maintainers;
            this.RepoNames = repoNames;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Permission = permission;
            this.ParentTeamId = parentTeamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsCreateRequest" /> class.
        /// </summary>
        public TeamsCreateRequest()
        {
        }
    }
}