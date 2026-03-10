//HintName: G.Models.ConversationHistoryRedactionConfig.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConversationHistoryRedactionConfig
    {
        /// <summary>
        /// Whether conversation history redaction is enabled<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The entities to redact from the conversation transcript, audio and analysis. Use top-level types like 'name', 'email_address', or dot notation for specific subtypes like 'name.full_name'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("entities")]
        public global::System.Collections.Generic.IList<global::G.ConfigEntityType>? Entities { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRedactionConfig" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether conversation history redaction is enabled<br/>
        /// Default Value: false
        /// </param>
        /// <param name="entities">
        /// The entities to redact from the conversation transcript, audio and analysis. Use top-level types like 'name', 'email_address', or dot notation for specific subtypes like 'name.full_name'.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationHistoryRedactionConfig(
            bool? enabled,
            global::System.Collections.Generic.IList<global::G.ConfigEntityType>? entities)
        {
            this.Enabled = enabled;
            this.Entities = entities;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationHistoryRedactionConfig" /> class.
        /// </summary>
        public ConversationHistoryRedactionConfig()
        {
        }
    }
}