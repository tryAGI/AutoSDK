//HintName: G.Models.Scenario.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Scenario
    {
        /// <summary>
        /// This is the unique identifier for the scenario.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid Id { get; set; } = default!;

        /// <summary>
        /// This is the unique identifier for the organization this scenario belongs to.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("orgId", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Guid OrgId { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the scenario was created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("createdAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime CreatedAt { get; set; } = default!;

        /// <summary>
        /// This is the ISO 8601 date-time string of when the scenario was last updated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updatedAt", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime UpdatedAt { get; set; } = default!;

        /// <summary>
        /// This is the name of the scenario.<br/>
        /// Example: Health Enrollment - Eligible Path
        /// </summary>
        /// <example>Health Enrollment - Eligible Path</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// This is the script/instructions for the tester to follow during the simulation.<br/>
        /// Example: You are calling to enroll in the Twin Health program. Confirm your identity when asked.
        /// </summary>
        /// <example>You are calling to enroll in the Twin Health program. Confirm your identity when asked.</example>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public string Instructions { get; set; } = default!;

        /// <summary>
        /// This is the structured output-based evaluation plan for the simulation.<br/>
        /// Each item defines a structured output to extract and evaluate against an expected value.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("evaluations", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EvaluationPlanItem> Evaluations { get; set; } = default!;

        /// <summary>
        /// Hooks to run on simulation lifecycle events
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("hooks")]
        public global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? Hooks { get; set; }

        /// <summary>
        /// Overrides to inject into the simulated target assistant or squad<br/>
        /// Example: {"variableValues":{"customerName":"Alice","orderId":"12345"}}
        /// </summary>
        /// <example>{"variableValues":{"customerName":"Alice","orderId":"12345"}}</example>
        [global::Newtonsoft.Json.JsonProperty("targetOverrides")]
        public global::G.AssistantOverrides? TargetOverrides { get; set; }

        /// <summary>
        /// Scenario-level tool call mocks to use during simulations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("toolMocks")]
        public global::System.Collections.Generic.IList<global::G.ScenarioToolMock>? ToolMocks { get; set; }

        /// <summary>
        /// Optional folder path for organizing scenarios.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("path")]
        public string? Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        /// <param name="id">
        /// This is the unique identifier for the scenario.
        /// </param>
        /// <param name="orgId">
        /// This is the unique identifier for the organization this scenario belongs to.
        /// </param>
        /// <param name="createdAt">
        /// This is the ISO 8601 date-time string of when the scenario was created.
        /// </param>
        /// <param name="updatedAt">
        /// This is the ISO 8601 date-time string of when the scenario was last updated.
        /// </param>
        /// <param name="name">
        /// This is the name of the scenario.<br/>
        /// Example: Health Enrollment - Eligible Path
        /// </param>
        /// <param name="instructions">
        /// This is the script/instructions for the tester to follow during the simulation.<br/>
        /// Example: You are calling to enroll in the Twin Health program. Confirm your identity when asked.
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
        /// <param name="toolMocks">
        /// Scenario-level tool call mocks to use during simulations.
        /// </param>
        /// <param name="path">
        /// Optional folder path for organizing scenarios.<br/>
        /// Supports up to 3 levels (e.g., "dept/feature/variant").<br/>
        /// Maps to GitOps resource folder structure.
        /// </param>
        public Scenario(
            global::System.Guid id,
            global::System.Guid orgId,
            global::System.DateTime createdAt,
            global::System.DateTime updatedAt,
            string name,
            string instructions,
            global::System.Collections.Generic.IList<global::G.EvaluationPlanItem> evaluations,
            global::System.Collections.Generic.IList<global::G.OneOf<global::G.SimulationHookCallStarted, global::G.SimulationHookCallEnded>>? hooks,
            global::G.AssistantOverrides? targetOverrides,
            global::System.Collections.Generic.IList<global::G.ScenarioToolMock>? toolMocks,
            string? path)
        {
            this.Id = id;
            this.OrgId = orgId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.Evaluations = evaluations ?? throw new global::System.ArgumentNullException(nameof(evaluations));
            this.Hooks = hooks;
            this.TargetOverrides = targetOverrides;
            this.ToolMocks = toolMocks;
            this.Path = path;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Scenario" /> class.
        /// </summary>
        public Scenario()
        {
        }
    }
}