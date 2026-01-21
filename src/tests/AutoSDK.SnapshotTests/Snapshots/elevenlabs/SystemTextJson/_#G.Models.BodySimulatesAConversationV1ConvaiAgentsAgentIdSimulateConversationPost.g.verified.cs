//HintName: G.Models.BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost" /> class.
        /// </summary>
        /// <param name="simulationSpecification">
        /// A specification detailing how the conversation should be simulated
        /// </param>
        /// <param name="extraEvaluationCriteria">
        /// A list of evaluation criteria to test
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost(
            global::G.ConversationSimulationSpecification simulationSpecification,
            global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? extraEvaluationCriteria)
        {
            this.SimulationSpecification = simulationSpecification ?? throw new global::System.ArgumentNullException(nameof(simulationSpecification));
            this.ExtraEvaluationCriteria = extraEvaluationCriteria;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost" /> class.
        /// </summary>
        public BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost()
        {
        }
    }
}