//HintName: G.Models.InlineCorporaSearchToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A corpora search tool configuration defined inline in the agent.
    /// </summary>
    public sealed partial class InlineCorporaSearchToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'corpora_search' for inline corpora search tool configurations.<br/>
        /// Default Value: corpora_search
        /// </summary>
        /// <default>"corpora_search"</default>
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
        /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("argument_override")]
        public global::G.CorporaSearchToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("query_configuration", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.AgentCorporaSearchQueryConfiguration QueryConfiguration { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCorporaSearchToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'corpora_search' for inline corpora search tool configurations.<br/>
        /// Default Value: corpora_search
        /// </param>
        /// <param name="queryConfiguration">
        /// Agent-specific query configuration that supports eager references. Use this in agent tool configurations when turn-start resolution is needed.
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
        /// LLM-exposed parameters for the corpora search tool that can be filled in during execution.
        /// </param>
        public InlineCorporaSearchToolConfiguration(
            string type,
            global::G.AgentCorporaSearchQueryConfiguration queryConfiguration,
            string? descriptionTemplate,
            global::G.CorporaSearchToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
            this.QueryConfiguration = queryConfiguration ?? throw new global::System.ArgumentNullException(nameof(queryConfiguration));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineCorporaSearchToolConfiguration" /> class.
        /// </summary>
        public InlineCorporaSearchToolConfiguration()
        {
        }
    }
}