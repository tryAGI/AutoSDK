//HintName: G.Models.InlineGetDocumentTextToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A get document text tool configuration defined inline in the agent for fetching document text content from a corpus.
    /// </summary>
    public sealed partial class InlineGetDocumentTextToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'get_document_text' for inline get document text tool configurations.<br/>
        /// Default Value: get_document_text
        /// </summary>
        /// <default>"get_document_text"</default>
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
        /// Configurable parameters for the get document text tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("argument_override")]
        public global::G.GetDocumentTextParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// User-configurable settings for the get document text tool. These parameters are never exposed to the agent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tool_configuration")]
        public global::G.GetDocumentTextConfiguration? ToolConfiguration { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineGetDocumentTextToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'get_document_text' for inline get document text tool configurations.<br/>
        /// Default Value: get_document_text
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
        /// Configurable parameters for the get document text tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
        /// <param name="toolConfiguration">
        /// User-configurable settings for the get document text tool. These parameters are never exposed to the agent.
        /// </param>
        public InlineGetDocumentTextToolConfiguration(
            string type,
            string? descriptionTemplate,
            global::G.GetDocumentTextParameters? argumentOverride,
            global::G.GetDocumentTextConfiguration? toolConfiguration)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
            this.ToolConfiguration = toolConfiguration;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineGetDocumentTextToolConfiguration" /> class.
        /// </summary>
        public InlineGetDocumentTextToolConfiguration()
        {
        }
    }
}