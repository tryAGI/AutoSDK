//HintName: G.Models.GetSimulationTestResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetSimulationTestResponseModel
    {
        /// <summary>
        /// Metadata of a conversation this test was created from (if applicable).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("from_conversation_metadata")]
        public global::G.TestFromConversationMetadataOutput? FromConversationMetadata { get; set; }

        /// <summary>
        /// Dynamic variables to replace in the agent config during testing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dynamic_variables")]
        public object? DynamicVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chat_history")]
        public global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? ChatHistory { get; set; }

        /// <summary>
        /// Default Value: simulation
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success_condition")]
        public string? SuccessCondition { get; set; }

        /// <summary>
        /// Description of the simulation scenario and user persona for simulation tests.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation_scenario")]
        public string? SimulationScenario { get; set; }

        /// <summary>
        /// Maximum number of conversation turns for simulation tests.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation_max_turns")]
        public int? SimulationMaxTurns { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSimulationTestResponseModel" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="fromConversationMetadata">
        /// Metadata of a conversation this test was created from (if applicable).
        /// </param>
        /// <param name="dynamicVariables">
        /// Dynamic variables to replace in the agent config during testing
        /// </param>
        /// <param name="chatHistory"></param>
        /// <param name="type">
        /// Default Value: simulation
        /// </param>
        /// <param name="successCondition">
        /// A prompt that evaluates whether the agent's response is successful. Should return True or False.
        /// </param>
        /// <param name="simulationScenario">
        /// Description of the simulation scenario and user persona for simulation tests.
        /// </param>
        /// <param name="simulationMaxTurns">
        /// Maximum number of conversation turns for simulation tests.<br/>
        /// Default Value: 5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetSimulationTestResponseModel(
            string id,
            string name,
            global::G.TestFromConversationMetadataOutput? fromConversationMetadata,
            object? dynamicVariables,
            global::System.Collections.Generic.IList<global::G.ConversationHistoryTranscriptCommonModelOutput>? chatHistory,
            string? type,
            string? successCondition,
            string? simulationScenario,
            int? simulationMaxTurns)
        {
            this.FromConversationMetadata = fromConversationMetadata;
            this.DynamicVariables = dynamicVariables;
            this.ChatHistory = chatHistory;
            this.Type = type;
            this.SuccessCondition = successCondition;
            this.SimulationScenario = simulationScenario;
            this.SimulationMaxTurns = simulationMaxTurns;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSimulationTestResponseModel" /> class.
        /// </summary>
        public GetSimulationTestResponseModel()
        {
        }
    }
}