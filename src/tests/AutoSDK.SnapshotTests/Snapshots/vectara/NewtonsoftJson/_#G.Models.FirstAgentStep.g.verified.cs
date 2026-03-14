//HintName: G.Models.FirstAgentStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The entry point step for an agent, with a unique name.<br/>
    /// See AgentStep for full step documentation.
    /// </summary>
    public sealed partial class FirstAgentStep
    {
        /// <summary>
        /// Unique identifier for this step within the agent. Must not conflict with any key in the steps map.<br/>
        /// Default Value: first_step<br/>
        /// Example: classifier
        /// </summary>
        /// <default>"first_step"</default>
        /// <example>classifier</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Deprecated. This field is ignored and exists only for backward compatibility.<br/>
        /// Default Value: conversational
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Type { get; set; }

        /// <summary>
        /// List of instructions that guide the agent's behavior in this step.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.AgentStepInstruction> Instructions { get; set; } = default!;

        /// <summary>
        /// Default Value: {"type":"default"}
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_parser", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentOutputParser OutputParser { get; set; } = default!;

        /// <summary>
        /// Reminders injected into conversation messages when specific events occur.<br/>
        /// Default Value: []
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reminders")]
        public global::System.Collections.Generic.IList<global::G.AgentStepReminder>? Reminders { get; set; }

        /// <summary>
        /// Conditional transitions to other steps.<br/>
        /// Evaluated in order; first matching condition is selected.<br/>
        /// A next_step without a condition acts as a catch-all/default.<br/>
        /// If no condition matches, the agent remains on the current step and the agent ends output.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_steps")]
        public global::System.Collections.Generic.IList<global::G.NextStep>? NextSteps { get; set; }

        /// <summary>
        /// List of tool configuration names that this step is allowed to use.<br/>
        /// If not specified (null), all tools defined in the agent's tool_configurations are allowed.<br/>
        /// If set to an empty array, no tools are allowed and the agent can only respond with text.<br/>
        /// Example: [customer_search, web_search]
        /// </summary>
        /// <example>[customer_search, web_search]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// List of skill names that this step is allowed to use.<br/>
        /// If not specified (null), all skills defined in the agent's skills map are allowed.<br/>
        /// If set to an empty array, no skills are available and the invoke_skill tool is not shown.<br/>
        /// Example: [code_review, debugging]
        /// </summary>
        /// <example>[code_review, debugging]</example>
        [global::Newtonsoft.Json.JsonProperty("allowed_skills")]
        public global::System.Collections.Generic.IList<string>? AllowedSkills { get; set; }

        /// <summary>
        /// Step name to resume at when the session receives the next user message.<br/>
        /// If not specified, the session re-enters at this step (i.e., stays here).<br/>
        /// Set to the agent's first_step_name to always restart from the beginning.<br/>
        /// Example: classifier
        /// </summary>
        /// <example>classifier</example>
        [global::Newtonsoft.Json.JsonProperty("reentry_step")]
        public string? ReentryStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstAgentStep" /> class.
        /// </summary>
        /// <param name="name">
        /// Unique identifier for this step within the agent. Must not conflict with any key in the steps map.<br/>
        /// Default Value: first_step<br/>
        /// Example: classifier
        /// </param>
        /// <param name="instructions">
        /// List of instructions that guide the agent's behavior in this step.
        /// </param>
        /// <param name="outputParser">
        /// Default Value: {"type":"default"}
        /// </param>
        /// <param name="reminders">
        /// Reminders injected into conversation messages when specific events occur.<br/>
        /// Default Value: []
        /// </param>
        /// <param name="nextSteps">
        /// Conditional transitions to other steps.<br/>
        /// Evaluated in order; first matching condition is selected.<br/>
        /// A next_step without a condition acts as a catch-all/default.<br/>
        /// If no condition matches, the agent remains on the current step and the agent ends output.
        /// </param>
        /// <param name="allowedTools">
        /// List of tool configuration names that this step is allowed to use.<br/>
        /// If not specified (null), all tools defined in the agent's tool_configurations are allowed.<br/>
        /// If set to an empty array, no tools are allowed and the agent can only respond with text.<br/>
        /// Example: [customer_search, web_search]
        /// </param>
        /// <param name="allowedSkills">
        /// List of skill names that this step is allowed to use.<br/>
        /// If not specified (null), all skills defined in the agent's skills map are allowed.<br/>
        /// If set to an empty array, no skills are available and the invoke_skill tool is not shown.<br/>
        /// Example: [code_review, debugging]
        /// </param>
        /// <param name="reentryStep">
        /// Step name to resume at when the session receives the next user message.<br/>
        /// If not specified, the session re-enters at this step (i.e., stays here).<br/>
        /// Set to the agent's first_step_name to always restart from the beginning.<br/>
        /// Example: classifier
        /// </param>
        public FirstAgentStep(
            string name,
            global::System.Collections.Generic.IList<global::G.AgentStepInstruction> instructions,
            global::G.AgentOutputParser outputParser,
            global::System.Collections.Generic.IList<global::G.AgentStepReminder>? reminders,
            global::System.Collections.Generic.IList<global::G.NextStep>? nextSteps,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::System.Collections.Generic.IList<string>? allowedSkills,
            string? reentryStep)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputParser = outputParser;
            this.Reminders = reminders;
            this.NextSteps = nextSteps;
            this.AllowedTools = allowedTools;
            this.AllowedSkills = allowedSkills;
            this.ReentryStep = reentryStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FirstAgentStep" /> class.
        /// </summary>
        public FirstAgentStep()
        {
        }
    }
}