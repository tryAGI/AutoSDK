//HintName: G.Models.ConversationConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"client_events":["audio","interruption"],"max_duration_seconds":600}
    /// </summary>
    public sealed partial class ConversationConfig
    {
        /// <summary>
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_only")]
        public bool? TextOnly { get; set; }

        /// <summary>
        /// The maximum duration of a conversation in seconds<br/>
        /// Default Value: 600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_duration_seconds")]
        public int? MaxDurationSeconds { get; set; }

        /// <summary>
        /// The events that will be sent to the client
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_events")]
        public global::System.Collections.Generic.IList<global::G.ClientEvent>? ClientEvents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationConfig" /> class.
        /// </summary>
        /// <param name="textOnly">
        /// If enabled audio will not be processed and only text will be used, use to avoid audio pricing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maxDurationSeconds">
        /// The maximum duration of a conversation in seconds<br/>
        /// Default Value: 600
        /// </param>
        /// <param name="clientEvents">
        /// The events that will be sent to the client
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationConfig(
            bool? textOnly,
            int? maxDurationSeconds,
            global::System.Collections.Generic.IList<global::G.ClientEvent>? clientEvents)
        {
            this.TextOnly = textOnly;
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