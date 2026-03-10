//HintName: G.Models.ConversationConfigWorkflowOverride.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
    /// </summary>
    public sealed partial class ConversationConfigWorkflowOverride
    {
        /// <summary>
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// The maximum duration of a conversation in seconds
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// The events that will be sent to the client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_events")]
        public global::System.Collections.Generic.IList<global::G.ClientEvent>? ClientEvents { get; set; }

        /// <summary>
        /// Enable real-time monitoring of conversations via WebSocket
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monitoring_enabled")]
        public bool? MonitoringEnabled { get; set; }

        /// <summary>
        /// The events that will be sent to monitoring connections.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monitoring_events")]
        public global::System.Collections.Generic.IList<global::G.ClientEvent>? MonitoringEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigWorkflowOverride" /> class.
        /// </summary>
        /// <param name="textOnly">
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.
        /// </param>
        /// <param name="maxDurationSeconds">
        /// The maximum duration of a conversation in seconds
        /// </param>
        /// <param name="clientEvents">
        /// The events that will be sent to the client
        /// </param>
        /// <param name="monitoringEnabled">
        /// Enable real-time monitoring of conversations via WebSocket
        /// </param>
        /// <param name="monitoringEvents">
        /// The events that will be sent to monitoring connections.
        /// </param>
        public ConversationConfigWorkflowOverride(
            bool? textOnly,
            int? maxDurationSeconds,
            global::System.Collections.Generic.IList<global::G.ClientEvent>? clientEvents,
            bool? monitoringEnabled,
            global::System.Collections.Generic.IList<global::G.ClientEvent>? monitoringEvents)
        {
            this.TextOnly = textOnly;
            this.MaxDurationSeconds = maxDurationSeconds;
            this.ClientEvents = clientEvents;
            this.MonitoringEnabled = monitoringEnabled;
            this.MonitoringEvents = monitoringEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfigWorkflowOverride" /> class.
        /// </summary>
        public ConversationConfigWorkflowOverride()
        {
        }
    }
}