//HintName: G.Models.AlertPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_type")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AlertPublicAlertTypeJsonConverter))]
        public global::G.AlertPublicAlertType? AlertType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("webhook", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookPublic Webhook { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("triggers")]
        public global::System.Collections.Generic.IList<global::G.AlertTriggerPublic>? Triggers { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_at")]
        public global::System.DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_updated_by")]
        public string? LastUpdatedBy { get; set; }

        /// <summary>
        /// Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertPublic" /> class.
        /// </summary>
        /// <param name="webhook"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="alertType"></param>
        /// <param name="metadata"></param>
        /// <param name="triggers"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedAt">
        /// Included only in responses
        /// </param>
        /// <param name="lastUpdatedBy">
        /// Included only in responses
        /// </param>
        /// <param name="projectId">
        /// Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.
        /// </param>
        public AlertPublic(
            global::G.WebhookPublic webhook,
            global::System.Guid? id,
            string? name,
            bool? enabled,
            global::G.AlertPublicAlertType? alertType,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::G.AlertTriggerPublic>? triggers,
            global::System.DateTime? createdAt,
            string? createdBy,
            global::System.DateTime? lastUpdatedAt,
            string? lastUpdatedBy,
            global::System.Guid? projectId)
        {
            this.Id = id;
            this.Name = name;
            this.Enabled = enabled;
            this.AlertType = alertType;
            this.Metadata = metadata;
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.Triggers = triggers;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.LastUpdatedAt = lastUpdatedAt;
            this.LastUpdatedBy = lastUpdatedBy;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertPublic" /> class.
        /// </summary>
        public AlertPublic()
        {
        }
    }
}