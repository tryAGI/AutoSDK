//HintName: G.Models.ConversationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationConfig
    {
        /// <summary>
        /// The maximum duration of a conversation in seconds<br/>
        /// Default Value: 600
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// The events that will be sent to the client
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("client_events")]
        public global::System.Collections.Generic.IList<global::G.ClientEvent>? ClientEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfig" /> class.
        /// </summary>
        /// <param name="maxDurationSeconds">
        /// The maximum duration of a conversation in seconds<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="clientEvents">
        /// The events that will be sent to the client
        /// </param>
        public ConversationConfig(
            int? maxDurationSeconds,
            global::System.Collections.Generic.IList<global::G.ClientEvent>? clientEvents)
        {
            this.MaxDurationSeconds = maxDurationSeconds;
            this.ClientEvents = clientEvents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfig" /> class.
        /// </summary>
        public ConversationConfig()
        {
        }
    }
}