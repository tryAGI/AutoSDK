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
        [global::Newtonsoft.Json.JsonProperty("simulation_specification", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ConversationSimulationSpecification SimulationSpecification { get; set; } = default!;

        /// <summary>
        /// A list of evaluation criteria to test
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_evaluation_criteria")]
        public global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? ExtraEvaluationCriteria { get; set; }

        /// <summary>
        /// Maximum number of new turns to generate in the conversation simulation<br/>
        /// Default Value: 10000
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("new_turns_limit")]
        public int? NewTurnsLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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
        /// <param name="newTurnsLimit">
        /// Maximum number of new turns to generate in the conversation simulation<br/>
        /// Default Value: 10000
        /// </param>
        public BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost(
            global::G.ConversationSimulationSpecification simulationSpecification,
            global::System.Collections.Generic.IList<global::G.PromptEvaluationCriteria>? extraEvaluationCriteria,
            int? newTurnsLimit)
        {
            this.SimulationSpecification = simulationSpecification ?? throw new global::System.ArgumentNullException(nameof(simulationSpecification));
            this.ExtraEvaluationCriteria = extraEvaluationCriteria;
            this.NewTurnsLimit = newTurnsLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost" /> class.
        /// </summary>
        public BodySimulatesAConversationV1ConvaiAgentsAgentIdSimulateConversationPost()
        {
        }
    }
}