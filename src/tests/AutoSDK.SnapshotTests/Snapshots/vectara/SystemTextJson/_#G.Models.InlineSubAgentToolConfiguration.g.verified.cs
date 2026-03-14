//HintName: G.Models.InlineSubAgentToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A sub-agent tool configuration defined inline in the agent for invoking specialized sub-agents.
    /// </summary>
    public sealed partial class InlineSubAgentToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'sub_agent' for inline sub-agent tool configurations.<br/>
        /// Default Value: sub_agent
        /// </summary>
        /// <default>"sub_agent"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "sub_agent";

        /// <summary>
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// Configurable parameters for the sub-agent tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::G.SubAgentToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sub_agent_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SubAgentConfiguration SubAgentConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineSubAgentToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'sub_agent' for inline sub-agent tool configurations.<br/>
        /// Default Value: sub_agent
        /// </param>
        /// <param name="descriptionTemplate">
        /// Velocity template for generating dynamic tool descriptions. When set, this template is rendered at runtime to produce the tool description.<br/>
        /// Available Velocity variables:<br/>
        /// - `$agent.name` - Agent name<br/>
        /// - `$agent.metadata` - Agent metadata map<br/>
        /// - `$session.key` - Session key<br/>
        /// - `$session.metadata` - Session metadata map<br/>
        /// - `$currentDate` - Current date/time in ISO 8601 format (e.g., "2025-10-24T15:30:45Z")<br/>
        /// Example: "Search tool configured for agent $agent.name on $currentDate"
        /// </param>
        /// <param name="argumentOverride">
        /// Configurable parameters for the sub-agent tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
        /// <param name="subAgentConfiguration">
        /// User-configurable settings for the sub-agent tool. These parameters are never exposed to the agent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineSubAgentToolConfiguration(
            string type,
            global::G.SubAgentConfiguration subAgentConfiguration,
            string? descriptionTemplate,
            global::G.SubAgentToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.SubAgentConfiguration = subAgentConfiguration ?? throw new global::System.ArgumentNullException(nameof(subAgentConfiguration));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineSubAgentToolConfiguration" /> class.
        /// </summary>
        public InlineSubAgentToolConfiguration()
        {
        }
    }
}