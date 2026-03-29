//HintName: G.Models.SimulationRunTargetAssistant.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SimulationRunTargetAssistant
    {
        /// <summary>
        /// Type of target
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.SimulationRunTargetAssistantType Type { get; set; }

        /// <summary>
        /// ID of an existing assistant to test against. Cannot be combined with inline assistant.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistantId")]
        public global::System.Guid? AssistantId { get; set; }

        /// <summary>
        /// Inline assistant configuration to test against. Cannot be combined with assistantId.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("assistant")]
        public global::G.CreateAssistantDTO? Assistant { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTargetAssistant" /> class.
        /// </summary>
        /// <param name="type">
        /// Type of target
        /// </param>
        /// <param name="assistantId">
        /// ID of an existing assistant to test against. Cannot be combined with inline assistant.
        /// </param>
        /// <param name="assistant">
        /// Inline assistant configuration to test against. Cannot be combined with assistantId.
        /// </param>
        public SimulationRunTargetAssistant(
            global::G.SimulationRunTargetAssistantType type,
            global::System.Guid? assistantId,
            global::G.CreateAssistantDTO? assistant)
        {
            this.Type = type;
            this.AssistantId = assistantId;
            this.Assistant = assistant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationRunTargetAssistant" /> class.
        /// </summary>
        public SimulationRunTargetAssistant()
        {
        }
    }
}