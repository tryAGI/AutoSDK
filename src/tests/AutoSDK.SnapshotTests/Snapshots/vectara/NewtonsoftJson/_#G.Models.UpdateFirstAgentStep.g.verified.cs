//HintName: G.Models.UpdateFirstAgentStep.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
    /// Includes an optional name field to rename the first step.
    /// </summary>
    public sealed partial class UpdateFirstAgentStep
    {
        /// <summary>
        /// Rename the first step. If omitted, the name is preserved.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated. Previously used as a discriminator.<br/>
        /// Default Value: conversational
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Type { get; set; }

        /// <summary>
        /// List of instructions that guide the agent's behavior. Set to null to clear all instructions.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("instructions")]
        public global::System.Collections.Generic.IList<global::G.AgentStepInstruction>? Instructions { get; set; }

        /// <summary>
        /// Configuration for how the agent's output should be parsed and formatted.<br/>
        /// The output parser determines how the agent's responses are processed before being returned to the user.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("output_parser")]
        public global::G.AgentOutputParser? OutputParser { get; set; }

        /// <summary>
        /// Reminders injected into conversation messages. Set to null to clear all reminders.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reminders")]
        public global::System.Collections.Generic.IList<global::G.AgentStepReminder>? Reminders { get; set; }

        /// <summary>
        /// Conditional transitions to other steps. Set to null to clear.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_steps")]
        public global::System.Collections.Generic.IList<global::G.NextStep>? NextSteps { get; set; }

        /// <summary>
        /// Tool configuration names this step may invoke. Set to null to clear.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// Skill names this step may use. Set to null to clear (allows all skills).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("allowed_skills")]
        public global::System.Collections.Generic.IList<string>? AllowedSkills { get; set; }

        /// <summary>
        /// Step name to resume at when the session receives the next user message.<br/>
        /// Set to null to clear (re-enters at this step).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("reentry_step")]
        public string? ReentryStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirstAgentStep" /> class.
        /// </summary>
        /// <param name="name">
        /// Rename the first step. If omitted, the name is preserved.
        /// </param>
        /// <param name="instructions">
        /// List of instructions that guide the agent's behavior. Set to null to clear all instructions.
        /// </param>
        /// <param name="outputParser">
        /// Configuration for how the agent's output should be parsed and formatted.<br/>
        /// The output parser determines how the agent's responses are processed before being returned to the user.
        /// </param>
        /// <param name="reminders">
        /// Reminders injected into conversation messages. Set to null to clear all reminders.
        /// </param>
        /// <param name="nextSteps">
        /// Conditional transitions to other steps. Set to null to clear.
        /// </param>
        /// <param name="allowedTools">
        /// Tool configuration names this step may invoke. Set to null to clear.
        /// </param>
        /// <param name="allowedSkills">
        /// Skill names this step may use. Set to null to clear (allows all skills).
        /// </param>
        /// <param name="reentryStep">
        /// Step name to resume at when the session receives the next user message.<br/>
        /// Set to null to clear (re-enters at this step).
        /// </param>
        public UpdateFirstAgentStep(
            string? name,
            global::System.Collections.Generic.IList<global::G.AgentStepInstruction>? instructions,
            global::G.AgentOutputParser? outputParser,
            global::System.Collections.Generic.IList<global::G.AgentStepReminder>? reminders,
            global::System.Collections.Generic.IList<global::G.NextStep>? nextSteps,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::System.Collections.Generic.IList<string>? allowedSkills,
            string? reentryStep)
        {
            this.Name = name;
            this.Instructions = instructions;
            this.OutputParser = outputParser;
            this.Reminders = reminders;
            this.NextSteps = nextSteps;
            this.AllowedTools = allowedTools;
            this.AllowedSkills = allowedSkills;
            this.ReentryStep = reentryStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateFirstAgentStep" /> class.
        /// </summary>
        public UpdateFirstAgentStep()
        {
        }
    }
}