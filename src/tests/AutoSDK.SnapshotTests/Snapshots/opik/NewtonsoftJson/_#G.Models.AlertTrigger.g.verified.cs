//HintName: G.Models.AlertTrigger.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTrigger
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("alert_id")]
        public global::System.Guid? AlertId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AlertTriggerEventType EventType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_configs")]
        public global::System.Collections.Generic.IList<global::G.AlertTriggerConfig>? TriggerConfigs { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTrigger" /> class.
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
        public AlertTrigger(
            global::G.AlertTriggerEventType eventType,
            global::System.Guid? id,
            global::System.Guid? alertId,
            global::System.Collections.Generic.IList<global::G.AlertTriggerConfig>? triggerConfigs,
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
        /// Initializes a new instance of the <see cref="AlertTrigger" /> class.
        /// </summary>
        public AlertTrigger()
        {
        }
    }
}