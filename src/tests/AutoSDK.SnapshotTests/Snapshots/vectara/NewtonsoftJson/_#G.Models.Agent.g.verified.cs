//HintName: G.Models.Agent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An AI agent that can use tools to provide intelligent responses and actions.
    /// </summary>
    public sealed partial class Agent
    {
        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::Newtonsoft.Json.JsonProperty("key", Required = global::Newtonsoft.Json.Required.Always)]
        public string Key { get; set; } = default!;

        /// <summary>
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </summary>
        /// <example>Customer Support Agent</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </summary>
        /// <example>An AI agent specialized in handling customer support inquiries using company documentation and support tools.</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is an agent tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </summary>
        /// <example>{"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}</example>
        [global::Newtonsoft.Json.JsonProperty("tool_configurations", Required = global::Newtonsoft.Json.Required.Always)]
        public object ToolConfigurations { get; set; } = default!;

        /// <summary>
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// The skill list (name + description) is shown in the system message; content is loaded on invocation.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices and security issues.","content":"When reviewing code, focus on..."}}
        /// </summary>
        /// <example>{"code_review":{"description":"Reviews code for best practices and security issues.","content":"When reviewing code, focus on..."}}</example>
        [global::Newtonsoft.Json.JsonProperty("skills")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? Skills { get; set; }

        /// <summary>
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentModel Model { get; set; } = default!;

        /// <summary>
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("first_step", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.FirstAgentStep FirstStep { get; set; } = default!;

        /// <summary>
        /// The name of the first step. Matches first_step.name.<br/>
        /// Example: classifier
        /// </summary>
        /// <example>classifier</example>
        [global::Newtonsoft.Json.JsonProperty("first_step_name")]
        public string? FirstStepName { get; set; }

        /// <summary>
        /// A map of additional named steps keyed by step name.<br/>
        /// The first_step can transition to steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </summary>
        /// <example>{"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}</example>
        [global::Newtonsoft.Json.JsonProperty("steps")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AgentStep>? Steps { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Example: {"department":"customer_service","version":"1.2.0","owner":"support-team"}
        /// </summary>
        /// <example>{"department":"customer_service","version":"1.2.0","owner":"support-team"}</example>
        [global::Newtonsoft.Json.JsonProperty("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the agent is currently enabled and available for use.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("enabled", Required = global::Newtonsoft.Json.Required.Always)]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Configuration for automatic context compaction.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("compaction")]
        public global::G.CompactionConfig? Compaction { get; set; }

        /// <summary>
        /// Configuration for offloading large tool outputs to artifacts.<br/>
        /// When tools produce outputs exceeding the size threshold, the output is stored<br/>
        /// as an artifact and replaced with a compact reference. The agent can then use<br/>
        /// artifact_read or artifact_grep to access the full content on demand.<br/>
        /// All fields are optional; omitted fields use model-inferred defaults.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_output_offloading")]
        public global::G.ToolOutputOffloadingConfiguration? ToolOutputOffloading { get; set; }

        /// <summary>
        /// Timestamp when the agent was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("created_at")]
        public global::System.DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the agent was last updated.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </summary>
        /// <example>2024-01-16T14:45:00Z</example>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        /// <param name="key">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is an agent tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// The skill list (name + description) is shown in the system message; content is loaded on invocation.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices and security issues.","content":"When reviewing code, focus on..."}}
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </param>
        /// <param name="firstStepName">
        /// The name of the first step. Matches first_step.name.<br/>
        /// Example: classifier
        /// </param>
        /// <param name="steps">
        /// A map of additional named steps keyed by step name.<br/>
        /// The first_step can transition to steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Example: {"department":"customer_service","version":"1.2.0","owner":"support-team"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent is currently enabled and available for use.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="compaction">
        /// Configuration for automatic context compaction.
        /// </param>
        /// <param name="toolOutputOffloading">
        /// Configuration for offloading large tool outputs to artifacts.<br/>
        /// When tools produce outputs exceeding the size threshold, the output is stored<br/>
        /// as an artifact and replaced with a compact reference. The agent can then use<br/>
        /// artifact_read or artifact_grep to access the full content on demand.<br/>
        /// All fields are optional; omitted fields use model-inferred defaults.
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the agent was created.<br/>
        /// Example: 2024-01-15T10:30:00Z
        /// </param>
        /// <param name="updatedAt">
        /// Timestamp when the agent was last updated.<br/>
        /// Example: 2024-01-16T14:45:00Z
        /// </param>
        public Agent(
            string key,
            string name,
            object toolConfigurations,
            global::G.AgentModel model,
            global::G.FirstAgentStep firstStep,
            bool enabled,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? skills,
            string? firstStepName,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentStep>? steps,
            object? metadata,
            global::G.CompactionConfig? compaction,
            global::G.ToolOutputOffloadingConfiguration? toolOutputOffloading,
            global::System.DateTime? createdAt,
            global::System.DateTime? updatedAt)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ToolConfigurations = toolConfigurations ?? throw new global::System.ArgumentNullException(nameof(toolConfigurations));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FirstStep = firstStep ?? throw new global::System.ArgumentNullException(nameof(firstStep));
            this.Enabled = enabled;
            this.Description = description;
            this.Skills = skills;
            this.FirstStepName = firstStepName;
            this.Steps = steps;
            this.Metadata = metadata;
            this.Compaction = compaction;
            this.ToolOutputOffloading = toolOutputOffloading;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Agent" /> class.
        /// </summary>
        public Agent()
        {
        }
    }
}