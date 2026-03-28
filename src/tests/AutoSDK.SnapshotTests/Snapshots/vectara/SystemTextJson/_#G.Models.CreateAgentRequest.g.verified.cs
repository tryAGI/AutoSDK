//HintName: G.Models.CreateAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for creating a new agent.<br/>
    /// The entry point must be defined via first_step_name (preferred) or first_step (deprecated).
    /// </summary>
    public sealed partial class CreateAgentRequest
    {
        /// <summary>
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </summary>
        /// <example>customer_support</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        public string? Key { get; set; }

        /// <summary>
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </summary>
        /// <example>Customer Support Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </summary>
        /// <example>An AI agent specialized in handling customer support inquiries using company documentation and support tools.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is the AgentToolConfiguration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </summary>
        /// <example>{"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configurations")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ToolConfigurations { get; set; }

        /// <summary>
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}
        /// </summary>
        /// <example>{"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? Skills { get; set; }

        /// <summary>
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.AgentModel Model { get; set; }

        /// <summary>
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step")]
        public global::G.FirstAgentStep? FirstStep { get; set; }

        /// <summary>
        /// Name of a step in the steps map to use as the entry point. This is the preferred<br/>
        /// way to define the entry point - define all steps in the steps map and reference<br/>
        /// the entry point by name here.<br/>
        /// Example: classifier
        /// </summary>
        /// <example>classifier</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step_name")]
        public string? FirstStepName { get; set; }

        /// <summary>
        /// A map of named steps keyed by step name.<br/>
        /// Steps can transition to other steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </summary>
        /// <example>{"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AgentStep>? Steps { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Default Value: {}<br/>
        /// Example: {"department":"customer_service","version":"1.0.0","owner":"support-team"}
        /// </summary>
        /// <example>{"department":"customer_service","version":"1.0.0","owner":"support-team"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the agent should be enabled upon creation.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Configuration for automatic context compaction.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("compaction")]
        public global::G.CompactionConfig? Compaction { get; set; }

        /// <summary>
        /// Configuration for offloading large tool outputs to artifacts.<br/>
        /// When tools produce outputs exceeding the size threshold, the output is stored<br/>
        /// as an artifact and replaced with a compact reference. The agent can then use<br/>
        /// artifact_read or artifact_grep to access the full content on demand.<br/>
        /// All fields are optional; omitted fields use model-inferred defaults.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_output_offloading")]
        public global::G.ToolOutputOffloadingConfiguration? ToolOutputOffloading { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. The key is the name of the tool configuration and the value is the AgentToolConfiguration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="key">
        /// A unique key that identifies an agent.<br/>
        /// Example: customer_support
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities.<br/>
        /// Example: An AI agent specialized in handling customer support inquiries using company documentation and support tools.
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent, keyed by skill name.<br/>
        /// Skills provide specialized instructions that can be invoked during agent execution.<br/>
        /// Example: {"code_review":{"description":"Reviews code for best practices.","content":"When reviewing code..."}}
        /// </param>
        /// <param name="firstStep">
        /// The entry point step for an agent, with a unique name.<br/>
        /// See AgentStep for full step documentation.
        /// </param>
        /// <param name="firstStepName">
        /// Name of a step in the steps map to use as the entry point. This is the preferred<br/>
        /// way to define the entry point - define all steps in the steps map and reference<br/>
        /// the entry point by name here.<br/>
        /// Example: classifier
        /// </param>
        /// <param name="steps">
        /// A map of named steps keyed by step name.<br/>
        /// Steps can transition to other steps defined here via next_steps.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}],"output_parser":{"type":"default"}},"support_handler":{"instructions":[{"type":"inline","template":"Handle support requests"}],"output_parser":{"type":"default"}}}
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent for customization and configuration.<br/>
        /// Default Value: {}<br/>
        /// Example: {"department":"customer_service","version":"1.0.0","owner":"support-team"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent should be enabled upon creation.<br/>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateAgentRequest(
            string name,
            object toolConfigurations,
            global::G.AgentModel model,
            string? key,
            string? description,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? skills,
            global::G.FirstAgentStep? firstStep,
            string? firstStepName,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentStep>? steps,
            object? metadata,
            bool? enabled,
            global::G.CompactionConfig? compaction,
            global::G.ToolOutputOffloadingConfiguration? toolOutputOffloading)
        {
            this.Key = key;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.ToolConfigurations = toolConfigurations ?? throw new global::System.ArgumentNullException(nameof(toolConfigurations));
            this.Skills = skills;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.FirstStep = firstStep;
            this.FirstStepName = firstStepName;
            this.Steps = steps;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Compaction = compaction;
            this.ToolOutputOffloading = toolOutputOffloading;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAgentRequest" /> class.
        /// </summary>
        public CreateAgentRequest()
        {
        }
    }
}