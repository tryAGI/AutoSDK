//HintName: G.Models.ConversationSimulationSpecification.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A specification that will be used to simulate a conversation between an agent and an AI user.
    /// </summary>
    public sealed partial class ConversationSimulationSpecification
    {
        /// <summary>
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en"}
        /// </summary>
        /// <example>{"first_message":"Hello, how can I help you today?","language":"en"}</example>
        [global::Newtonsoft.Json.JsonProperty("simulated_user_config", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentConfigDBModel SimulatedUserConfig { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_mock_config")]
        public global::System.Collections.Generic.Dictionary<string, global::G.ToolMockConfig>? ToolMockConfig { get; set; }

        /// <summary>
        /// A partial conversation history to start the simulation from. If empty, simulation starts fresh.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("partial_conversation_history")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelInput>? PartialConversationHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSimulationSpecification" /> class.
        /// </summary>
        /// <param name="simulatedUserConfig">
        /// Example: {"first_message":"Hello, how can I help you today?","language":"en"}
        /// </param>
        /// <param name="toolMockConfig"></param>
        /// <param name="partialConversationHistory">
        /// A partial conversation history to start the simulation from. If empty, simulation starts fresh.
        /// </param>
        /// <param name="dynamicVariables"></param>
        public ConversationSimulationSpecification(
            global::G.AgentConfigDBModel simulatedUserConfig,
            global::System.Collections.Generic.Dictionary<string, global::G.ToolMockConfig>? toolMockConfig,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelInput>? partialConversationHistory,
            object? dynamicVariables)
        {
            this.SimulatedUserConfig = simulatedUserConfig ?? throw new global::System.ArgumentNullException(nameof(simulatedUserConfig));
            this.ToolMockConfig = toolMockConfig;
            this.PartialConversationHistory = partialConversationHistory;
            this.DynamicVariables = dynamicVariables;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSimulationSpecification" /> class.
        /// </summary>
        public ConversationSimulationSpecification()
        {
        }
    }
}