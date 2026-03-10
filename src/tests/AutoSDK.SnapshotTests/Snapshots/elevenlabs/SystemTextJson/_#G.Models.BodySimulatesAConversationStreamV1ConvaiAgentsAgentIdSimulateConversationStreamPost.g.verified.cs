//HintName: G.Models.BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost
    {
        /// <summary>
        /// A specification detailing how the conversation should be simulated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("simulation_specification")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ConversationSimulationSpecification SimulationSpecification { get; set; }

        /// <summary>
        /// A list of evaluation criteria to test
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("extra_evaluation_criteria")]
        public global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? ExtraEvaluationCriteria { get; set; }

        /// <summary>
        /// Maximum number of new turns to generate in the conversation simulation<br/>
        /// Default Value: 10000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_turns_limit")]
        public int? NewTurnsLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost" /> class.
        /// </summary>
        /// <param name="simulationSpecification">
        /// A specification detailing how the conversation should be simulated
        /// </param>
        /// <param name="extraEvaluationCriteria">
        /// A list of evaluation criteria to test
        /// </param>
        /// <param name="newTurnsLimit">
        /// Maximum number of new turns to generate in the conversation simulation<br/>
        /// Default Value: 10000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost(
            global::G.ConversationSimulationSpecification simulationSpecification,
            global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? extraEvaluationCriteria,
            int? newTurnsLimit)
        {
            this.SimulationSpecification = simulationSpecification ?? throw new global::System.ArgumentNullException(nameof(simulationSpecification));
            this.ExtraEvaluationCriteria = extraEvaluationCriteria;
            this.NewTurnsLimit = newTurnsLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost" /> class.
        /// </summary>
        public BodySimulatesAConversationStreamV1ConvaiAgentsAgentIdSimulateConversationStreamPost()
        {
        }
    }
}