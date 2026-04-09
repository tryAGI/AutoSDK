//HintName: G.Models.AlertTriggerWrite.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AlertTriggerWrite
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("event_type", Required = global::Newtonsoft.Json.Required.Always)]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.AlertTriggerWriteEventTypeJsonConverter))]
        public global::G.AlertTriggerWriteEventType EventType { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("trigger_configs")]
        public global::System.Collections.Generic.IList<global::G.AlertTriggerConfigWrite>? TriggerConfigs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerWrite" /> class.
        /// </summary>
        /// <param name="eventType"></param>
        /// <param name="id"></param>
        /// <param name="triggerConfigs"></param>
        public AlertTriggerWrite(
            global::G.AlertTriggerWriteEventType eventType,
            global::System.Guid? id,
            global::System.Collections.Generic.IList<global::G.AlertTriggerConfigWrite>? triggerConfigs)
        {
            this.Id = id;
            this.EventType = eventType;
            this.TriggerConfigs = triggerConfigs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AlertTriggerWrite" /> class.
        /// </summary>
        public AlertTriggerWrite()
        {
        }
    }
}