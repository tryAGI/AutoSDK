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
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. The options are:  
        /// **For a non-nested team:**  
        ///  * `secret` - only visible to organization owners and members of this team.  
        ///  * `closed` - visible to all members of this organization.  
        /// **For a parent or child team:**  
        ///  * `closed` - visible to all members of this organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("privacy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.TeamsUpdateLegacyRequestPrivacyJsonConverter))]
        public TeamsUpdateLegacyRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: 
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  
        ///  * `notifications_disabled` - no one receives notifications.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("notification_setting")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.TeamsUpdateLegacyRequestNotificationSettingJsonConverter))]
        public TeamsUpdateLegacyRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.
        /// <br/>Default Value: pull
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.TeamsUpdateLegacyRequestPermissionJsonConverter))]
        public TeamsUpdateLegacyRequestPermission? Permission { get; set; } = TeamsUpdateLegacyRequestPermission.Pull;

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
    }
}