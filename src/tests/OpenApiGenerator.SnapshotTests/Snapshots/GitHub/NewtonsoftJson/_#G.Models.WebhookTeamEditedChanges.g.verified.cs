//HintName: G.Models.WebhookTeamEditedChanges.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The changes to the team if the action was `edited`.
    /// </summary>
    public sealed partial class WebhookTeamEditedChanges
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public WebhookTeamEditedChangesDescription? Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public WebhookTeamEditedChangesName? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("privacy")]
        public WebhookTeamEditedChangesPrivacy? Privacy { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("notification_setting")]
        public WebhookTeamEditedChangesNotificationSetting? NotificationSetting { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("repository")]
        public WebhookTeamEditedChangesRepository? Repository { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}