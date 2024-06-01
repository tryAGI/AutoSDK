//HintName: G.Models.TeamsUpdateInOrgRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TeamsUpdateInOrgRequest
    {
        /// <summary>
        /// The name of the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The level of privacy this team should have. Editing teams without specifying this parameter leaves `privacy` intact. When a team is nested, the `privacy` for parent teams cannot be `secret`. The options are:  
        /// **For a non-nested team:**  
        ///  * `secret` - only visible to organization owners and members of this team.  
        ///  * `closed` - visible to all members of this organization.  
        /// **For a parent or child team:**  
        ///  * `closed` - visible to all members of this organization.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public TeamsUpdateInOrgRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. Editing teams without specifying this parameter leaves `notification_setting` intact. The options are: 
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  
        ///  * `notifications_disabled` - no one receives notifications.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public TeamsUpdateInOrgRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.
        /// <br/>Default Value: pull
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public TeamsUpdateInOrgRequestPermission? Permission { get; set; } = TeamsUpdateInOrgRequestPermission.Pull;

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
    }
}