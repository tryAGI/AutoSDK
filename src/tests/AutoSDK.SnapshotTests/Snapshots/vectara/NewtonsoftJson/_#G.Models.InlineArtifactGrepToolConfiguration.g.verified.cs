//HintName: G.Models.InlineArtifactGrepToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An artifact grep tool configuration defined inline in the agent for searching through artifact content.
    /// </summary>
    public sealed partial class InlineArtifactGrepToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'artifact_grep' for inline artifact grep tool configurations.<br/>
        /// Default Value: artifact_grep
        /// </summary>
        /// <default>"artifact_grep"</default>
        [global::Newtonsoft.Json.JsonProperty("type", Required = global::Newtonsoft.Json.Required.Always)]
        public string Type { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("description_template")]
        public string? DescriptionTemplate { get; set; }

        /// <summary>
        /// Configurable parameters for the artifact grep tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("argument_override")]
        public global::G.ArtifactGrepToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactGrepToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'artifact_grep' for inline artifact grep tool configurations.<br/>
        /// Default Value: artifact_grep
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
        /// Configurable parameters for the artifact grep tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
        public InlineArtifactGrepToolConfiguration(
            string type,
            string? descriptionTemplate,
            global::G.ArtifactGrepToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineArtifactGrepToolConfiguration" /> class.
        /// </summary>
        public InlineArtifactGrepToolConfiguration()
        {
        }
    }
}