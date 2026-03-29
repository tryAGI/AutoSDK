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
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.RelayTargetAssistantType Type { get; set; }

        /// <summary>
        /// The unique identifier of the assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public string? AssistantId { get; set; }

        /// <summary>
        /// The name of the assistant
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantName")]
        public string? AssistantName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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