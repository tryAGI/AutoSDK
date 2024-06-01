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
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// The description of the team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// List GitHub IDs for organization members who will become team maintainers.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("maintainers")]
        public global::System.Collections.Generic.IList<string?>? Maintainers { get; set; }

        /// <summary>
        /// The full name (e.g., "organization-name/repository-name") of repositories to add the team to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repo_names")]
        public global::System.Collections.Generic.IList<string?>? RepoNames { get; set; }

        /// <summary>
        /// The level of privacy this team should have. The options are:  
        /// **For a non-nested team:**  
        ///  * `secret` - only visible to organization owners and members of this team.  
        ///  * `closed` - visible to all members of this organization.  
        /// Default: `secret`  
        /// **For a parent or child team:**  
        ///  * `closed` - visible to all members of this organization.  
        /// Default for child team: `closed`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public TeamsCreateRequestPrivacy? Privacy { get; set; }

        /// <summary>
        /// The notification setting the team has chosen. The options are:  
        ///  * `notifications_enabled` - team members receive notifications when the team is @mentioned.  
        ///  * `notifications_disabled` - no one receives notifications.  
        /// Default: `notifications_enabled`
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public TeamsCreateRequestNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// **Deprecated**. The permission that new repositories will be added to the team with when none is specified.
        /// <br/>Default Value: pull
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("permission")]
        public TeamsCreateRequestPermission? Permission { get; set; } = TeamsCreateRequestPermission.Pull;

        /// <summary>
        /// The ID of a team to set as the parent team.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parent_team_id")]
        public int ParentTeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}