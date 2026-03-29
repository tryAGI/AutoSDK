//HintName: G.Models.AlertWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertWriteAlertTypeJsonConverter))]
        public global::G.AlertWriteAlertType? AlertType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookWrite Webhook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("triggers")]
        public global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>? Triggers { get; set; }

        /// <summary>
        /// Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        public global::System.Guid? ProjectId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertWrite" /> class.
        /// </summary>
        /// <param name="webhook"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="enabled"></param>
        /// <param name="alertType"></param>
        /// <param name="metadata"></param>
        /// <param name="triggers"></param>
        /// <param name="projectId">
        /// Optional project scope for this alert. When set, the alert is scoped to the specified project. Do NOT also provide a 'scope:project' trigger config — the system will create it automatically from this field. Sending both project_id and a scope:project trigger config will result in an error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertWrite(
            global::G.WebhookWrite webhook,
            global::System.Guid? id,
            string? name,
            bool? enabled,
            global::G.AlertWriteAlertType? alertType,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::System.Collections.Generic.IList<global::G.AlertTriggerWrite>? triggers,
            global::System.Guid? projectId)
        {
            this.Id = id;
            this.Name = name;
            this.Enabled = enabled;
            this.AlertType = alertType;
            this.Metadata = metadata;
            this.Webhook = webhook ?? throw new global::System.ArgumentNullException(nameof(webhook));
            this.Triggers = triggers;
            this.ProjectId = projectId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertWrite" /> class.
        /// </summary>
        public AlertWrite()
        {
        }
    }
}