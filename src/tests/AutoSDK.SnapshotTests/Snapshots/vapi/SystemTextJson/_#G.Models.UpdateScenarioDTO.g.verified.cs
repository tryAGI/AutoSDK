//HintName: G.Models.UpdateScenarioDTO.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateScenarioDTO
    {
        /// <summary>
        /// This is the name of the scenario.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// This is the script/instructions for the tester to follow during the simulation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// This is the structured output-based evaluation plan for the simulation.<br/>
        /// Each item defines a structured output to extract and evaluate against an expected value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("evaluations")]
        public global::System.Collections.Generic.IList<global::G.EvaluationPlanItem>? Evaluations { get; set; }

        /// <summary>
        /// Hooks to run on simulation lifecycle events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hooks")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? Hooks { get; set; }

        /// <summary>
        /// Overrides to inject into the simulated target assistant or squad<br/>
        /// Example: {"variableValues":{"customerName":"Alice","orderId":"12345"}}
        /// </summary>
        /// <example>{"variableValues":{"customerName":"Alice","orderId":"12345"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetOverrides")]
        public global::G.AssistantOverrides? TargetOverrides { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("toolMocks")]
        public global::System.Collections.Generic.IList<global::G.ScenarioToolMock>? ToolMocks { get; set; }

        /// <summary>
        /// Optional folder path for organizing scenarios.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScenarioDTO" /> class.
        /// </summary>
        /// <param name="name">
        /// This is the name of the scenario.
        /// </param>
        /// <param name="instructions">
        /// This is the script/instructions for the tester to follow during the simulation.
        /// </param>
        /// <param name="evaluations">
        /// This is the structured output-based evaluation plan for the simulation.<br/>
        /// Each item defines a structured output to extract and evaluate against an expected value.
        /// </param>
        /// <param name="hooks">
        /// Hooks to run on simulation lifecycle events
        /// </param>
        /// <param name="targetOverrides">
        /// Overrides to inject into the simulated target assistant or squad<br/>
        /// Example: {"variableValues":{"customerName":"Alice","orderId":"12345"}}
        /// </param>
        /// <param name="toolMocks"></param>
        /// <param name="path">
        /// Optional folder path for organizing scenarios.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Set to null to remove from folder.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateScenarioDTO(
            string? name,
            string? instructions,
            global::System.Collections.Generic.IList<global::G.EvaluationPlanItem>? evaluations,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? hooks,
            global::G.AssistantOverrides? targetOverrides,
            global::System.Collections.Generic.IList<global::G.ScenarioToolMock>? toolMocks,
            string? path)
        {
            this.Name = name;
            this.Instructions = instructions;
            this.Evaluations = evaluations;
            this.Hooks = hooks;
            this.TargetOverrides = targetOverrides;
            this.ToolMocks = toolMocks;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateScenarioDTO" /> class.
        /// </summary>
        public UpdateScenarioDTO()
        {
        }
    }
}