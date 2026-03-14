//HintName: G.Models.UpdateAgentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request object for updating an existing agent. Omitted fields are preserved.<br/>
    /// Nullable fields (description, tool_configurations, metadata, enabled, guardrails)<br/>
    /// can be set to null to clear them.
    /// </summary>
    public sealed partial class UpdateAgentRequest
    {
        /// <summary>
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </summary>
        /// <example>Customer Support Agent</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A detailed description of the agent's purpose and capabilities. Set to null to clear.<br/>
        /// Example: An enhanced AI agent specialized in handling customer support inquiries.
        /// </summary>
        /// <example>An enhanced AI agent specialized in handling customer support inquiries.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
        /// Individual map values set to null will delete that tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </summary>
        /// <example>{"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tool_configurations")]
        public object? ToolConfigurations { get; set; }

        /// <summary>
        /// A map of skills available to the agent. Set to null to clear all skills.<br/>
        /// Individual map values set to null will delete that skill.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? Skills { get; set; }

        /// <summary>
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public global::G.AgentModel? Model { get; set; }

        /// <summary>
        /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
        /// Includes an optional name field to rename the first step.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step")]
        public global::G.UpdateFirstAgentStep? FirstStep { get; set; }

        /// <summary>
        /// Reassign the entry point to an existing step by name. This is the preferred way<br/>
        /// to change the entry point. The named step must exist in the steps map.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_step_name")]
        public string? FirstStepName { get; set; }

        /// <summary>
        /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
        /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
        /// </summary>
        /// <example>{"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Whether the agent is enabled. Set to null to reset to default (true).<br/>
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
        /// A map of additional named steps keyed by step name for partial update.<br/>
        /// Only provided keys are modified; missing keys are preserved.<br/>
        /// Set a key's value to null to delete that step.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
        /// </summary>
        /// <example>{"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("steps")]
        public global::System.Collections.Generic.Dictionary<string, global::G.UpdateAgentStep>? Steps { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The human-readable name of an agent.<br/>
        /// Example: Customer Support Agent
        /// </param>
        /// <param name="description">
        /// A detailed description of the agent's purpose and capabilities. Set to null to clear.<br/>
        /// Example: An enhanced AI agent specialized in handling customer support inquiries.
        /// </param>
        /// <param name="toolConfigurations">
        /// A map of tool configurations available to the agent. Set to null to clear all tools.<br/>
        /// Individual map values set to null will delete that tool configuration.<br/>
        /// Example: {"customer_search":{"type":"corpora_search","argument_override":{"query":"customer support documentation"}}}
        /// </param>
        /// <param name="skills">
        /// A map of skills available to the agent. Set to null to clear all skills.<br/>
        /// Individual map values set to null will delete that skill.
        /// </param>
        /// <param name="model">
        /// Configuration for the model used in this step, including the model name and arbitrary parameters.
        /// </param>
        /// <param name="firstStep">
        /// Partial update for the first (entry point) step. Omitted fields are preserved.<br/>
        /// Includes an optional name field to rename the first step.
        /// </param>
        /// <param name="firstStepName">
        /// Reassign the entry point to an existing step by name. This is the preferred way<br/>
        /// to change the entry point. The named step must exist in the steps map.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata associated with the agent. Set to null to clear.<br/>
        /// Example: {"department":"customer_service","version":"1.1.0","owner":"support-team","last_reviewed":"2024-01-15"}
        /// </param>
        /// <param name="enabled">
        /// Whether the agent is enabled. Set to null to reset to default (true).<br/>
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
        /// <param name="steps">
        /// A map of additional named steps keyed by step name for partial update.<br/>
        /// Only provided keys are modified; missing keys are preserved.<br/>
        /// Set a key's value to null to delete that step.<br/>
        /// Example: {"sales_handler":{"instructions":[{"type":"inline","template":"Handle sales inquiries"}]}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateAgentRequest(
            string? name,
            string? description,
            object? toolConfigurations,
            global::System.Collections.Generic.Dictionary<string, global::G.AgentSkill>? skills,
            global::G.AgentModel? model,
            global::G.UpdateFirstAgentStep? firstStep,
            string? firstStepName,
            object? metadata,
            bool? enabled,
            global::G.CompactionConfig? compaction,
            global::G.ToolOutputOffloadingConfiguration? toolOutputOffloading,
            global::System.Collections.Generic.Dictionary<string, global::G.UpdateAgentStep>? steps)
        {
            this.Name = name;
            this.Description = description;
            this.ToolConfigurations = toolConfigurations;
            this.Skills = skills;
            this.Model = model;
            this.FirstStep = firstStep;
            this.FirstStepName = firstStepName;
            this.Metadata = metadata;
            this.Enabled = enabled;
            this.Compaction = compaction;
            this.ToolOutputOffloading = toolOutputOffloading;
            this.Steps = steps;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateAgentRequest" /> class.
        /// </summary>
        public UpdateAgentRequest()
        {
        }
    }
}