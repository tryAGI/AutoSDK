//HintName: G.Models.RelayTargetAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RelayTargetAssistant
    {
        /// <summary>
        /// The type of relay target
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.RelayTargetAssistantTypeJsonConverter))]
        public global::G.RelayTargetAssistantType Type { get; set; }

        /// <summary>
        /// The unique identifier of the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// The name of the assistant
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistantName")]
        public string? AssistantName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetAssistant" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of relay target
        /// </param>
        /// <param name="assistantId">
        /// The unique identifier of the assistant
        /// </param>
        /// <param name="assistantName">
        /// The name of the assistant
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RelayTargetAssistant(
            global::G.RelayTargetAssistantType type,
            string? assistantId,
            string? assistantName)
        {
            this.Type = type;
            this.AssistantId = assistantId;
            this.AssistantName = assistantName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RelayTargetAssistant" /> class.
        /// </summary>
        public RelayTargetAssistant()
        {
        }
    }
}