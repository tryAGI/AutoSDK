//HintName: G.Models.AgentStep.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// A step in an agent's execution flow that defines how the agent processes and responds to input.<br/>
    /// The step name comes from the map key in the agent's steps map.<br/>
    /// A step gets all previous session history in the agent session, including any prior agent steps,<br/>
    /// then the agent decides what to do in this step based on the given instructions. Finally, the<br/>
    /// agent either stops working if there is no next step defined or continues to the first next step<br/>
    /// that matches the condition.<br/>
    /// An agent always executes steps serially. If parallel behavior is desired, giving the agent<br/>
    /// other agents as tools is usually the most correct approach.<br/>
    /// Each step can only use tools defined by its `allowed_tools` list; if this list is not specified<br/>
    /// then all tools known to the agent are allowed.
    /// </summary>
    public sealed partial class AgentStep
    {
        /// <summary>
        /// Deprecated. This field is ignored and exists only for backward compatibility.<br/>
        /// Default Value: conversational
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Type { get; set; }

        /// <summary>
        /// List of instructions that guide the agent's behavior in this step.<br/>
        /// If omitted, the agent may behave oddly as it has no system instructions and<br/>
        /// will just attempt to respond to user input and previous session history.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.AgentStepInstruction> Instructions { get; set; }

        /// <summary>
        /// How to parse and format the agent's output.<br/>
        /// Determines which event type is emitted.<br/>
        /// Defaults to 'default' parser if not specified.<br/>
        /// Default Value: {"type":"default"}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_parser")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.AgentOutputParserJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentOutputParser OutputParser { get; set; }

        /// <summary>
        /// Reminders injected into conversation messages when specific events occur. Useful for keeping the agent on-task during long conversations.<br/>
        /// Default Value: []
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reminders")]
        public global::System.Collections.Generic.IList<global::G.AgentStepReminder>? Reminders { get; set; }

        /// <summary>
        /// Conditional transitions to other steps.<br/>
        /// Evaluated in order; first matching condition is selected.<br/>
        /// A next_step without a condition acts as a catch-all/default.<br/>
        /// If no condition matches, the agent remains on the current step and the agent ends output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_steps")]
        public global::System.Collections.Generic.IList<global::G.NextStep>? NextSteps { get; set; }

        /// <summary>
        /// List of tool configuration names that this step is allowed to use.<br/>
        /// If not specified (null), all tools defined in the agent's tool_configurations are allowed.<br/>
        /// If set to an empty array, no tools are allowed and the agent can only respond with text.<br/>
        /// Tool names must reference keys in the agent's tool_configurations map.<br/>
        /// Example: [customer_search, web_search]
        /// </summary>
        /// <example>[customer_search, web_search]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_tools")]
        public global::System.Collections.Generic.IList<string>? AllowedTools { get; set; }

        /// <summary>
        /// List of skill names that this step is allowed to use.<br/>
        /// If not specified (null), all skills defined in the agent's skills map are allowed.<br/>
        /// If set to an empty array, no skills are available and the invoke_skill tool is not shown.<br/>
        /// Example: [code_review, debugging]
        /// </summary>
        /// <example>[code_review, debugging]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_skills")]
        public global::System.Collections.Generic.IList<string>? AllowedSkills { get; set; }

        /// <summary>
        /// Step name to resume at when the session receives the next user message.<br/>
        /// If not specified, the session re-enters at this step (i.e., stays here).<br/>
        /// Set to the agent's first_step_name to always restart from the beginning.<br/>
        /// Example: classifier
        /// </summary>
        /// <example>classifier</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("reentry_step")]
        public string? ReentryStep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStep" /> class.
        /// </summary>
        /// <param name="instructions">
        /// List of instructions that guide the agent's behavior in this step.<br/>
        /// If omitted, the agent may behave oddly as it has no system instructions and<br/>
        /// will just attempt to respond to user input and previous session history.
        /// </param>
        /// <param name="outputParser">
        /// How to parse and format the agent's output.<br/>
        /// Determines which event type is emitted.<br/>
        /// Defaults to 'default' parser if not specified.<br/>
        /// Default Value: {"type":"default"}
        /// </param>
        /// <param name="reminders">
        /// Reminders injected into conversation messages when specific events occur. Useful for keeping the agent on-task during long conversations.<br/>
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
        /// Tool names must reference keys in the agent's tool_configurations map.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AgentStep(
            global::System.Collections.Generic.IList<global::G.AgentStepInstruction> instructions,
            global::G.AgentOutputParser outputParser,
            global::System.Collections.Generic.IList<global::G.AgentStepReminder>? reminders,
            global::System.Collections.Generic.IList<global::G.NextStep>? nextSteps,
            global::System.Collections.Generic.IList<string>? allowedTools,
            global::System.Collections.Generic.IList<string>? allowedSkills,
            string? reentryStep)
        {
            this.Instructions = instructions ?? throw new global::System.ArgumentNullException(nameof(instructions));
            this.OutputParser = outputParser;
            this.Reminders = reminders;
            this.NextSteps = nextSteps;
            this.AllowedTools = allowedTools;
            this.AllowedSkills = allowedSkills;
            this.ReentryStep = reentryStep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AgentStep" /> class.
        /// </summary>
        public AgentStep()
        {
        }
    }
}