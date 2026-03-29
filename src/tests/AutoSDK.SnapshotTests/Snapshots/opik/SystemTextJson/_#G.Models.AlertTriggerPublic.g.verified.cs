//HintName: G.Models.AlertTriggerPublic.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTriggerPublic
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alert_id")]
        public global::System.Guid? AlertId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AlertTriggerPublicEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AlertTriggerPublicEventType EventType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_configs")]
        public global::System.Collections.Generic.IList<global::G.AlertTriggerConfigPublic>? TriggerConfigs { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerPublic" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="id"></param>
        /// <param name="alertId">
        /// Included only in responses
        /// </param>
        /// <param name="triggerConfigs"></param>
        /// <param name="createdAt">
        /// Included only in responses
        /// </param>
        /// <param name="createdBy">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AlertTriggerPublic(
            global::G.AlertTriggerPublicEventType eventType,
            global::System.Guid? id,
            global::System.Guid? alertId,
            global::System.Collections.Generic.IList<global::G.AlertTriggerConfigPublic>? triggerConfigs,
            global::System.DateTime? createdAt,
            string? createdBy)
        {
            this.Id = id;
            this.AlertId = alertId;
            this.EventType = eventType;
            this.TriggerConfigs = triggerConfigs;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerPublic" /> class.
        /// </summary>
        public AlertTriggerPublic()
        {
        }
    }
}