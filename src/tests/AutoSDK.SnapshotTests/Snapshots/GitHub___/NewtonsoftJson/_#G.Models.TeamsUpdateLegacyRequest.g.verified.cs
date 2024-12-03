//HintName: G.Models.TeamsUpdateLegacyRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsUpdateLegacyRequest
    {
        /// <summary>
        /// The name of the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  <br/>
        /// **For a non-nested team:**  <br/>
        ///  * `secret` - only visible to organization owners and members of this team.  <br/>
        ///  * `closed` - visible to all members of this organization.  <br/>
        /// **For a parent or child team:**  <br/>
        ///  * `closed` - visible to all members of this organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public global::G.TeamsUpdateLegacyRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: <br/>
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  <br/>
        ///  * `notifications_disabled` - no one receives notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public global::G.TeamsUpdateLegacyRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.<br/>
        /// Default Value: pull
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public global::G.TeamsUpdateLegacyRequestPermission? Permission { get; set; }

        /// <summary>
        /// The ID of a team to set as the parent team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_team_id")]
        public int? ParentTeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateLegacyRequest" /> class.
        /// </summary>
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
        public TeamsUpdateLegacyRequest(
            string name,
            string? description,
            global::G.TeamsUpdateLegacyRequestPrivacy? privacy,
            global::G.TeamsUpdateLegacyRequestNotificationSetting? notificationSetting,
            global::G.TeamsUpdateLegacyRequestPermission? permission,
            int? parentTeamId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Privacy = privacy;
            this.NotificationSetting = notificationSetting;
            this.Permission = permission;
            this.ParentTeamId = parentTeamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeamsUpdateLegacyRequest" /> class.
        /// </summary>
        public TeamsUpdateLegacyRequest()
        {
        }
    }
}