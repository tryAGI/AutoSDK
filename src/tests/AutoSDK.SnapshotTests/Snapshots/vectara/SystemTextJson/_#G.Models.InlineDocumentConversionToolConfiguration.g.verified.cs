//HintName: G.Models.InlineDocumentConversionToolConfiguration.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A document conversion tool configuration defined inline in the agent for converting document artifacts to various formats.
    /// </summary>
    public sealed partial class InlineDocumentConversionToolConfiguration
    {
        /// <summary>
        /// The type of tool configuration, which is always 'document_conversion' for inline document conversion tool configurations.<br/>
        /// Default Value: document_conversion
        /// </summary>
        /// <default>"document_conversion"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; } = "document_conversion";

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
        /// Configurable parameters for the document conversion tool. If not overridden, they will be required by the LLM to fill in.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("argument_override")]
        public global::G.DocumentConversionToolParameters? ArgumentOverride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDocumentConversionToolConfiguration" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of tool configuration, which is always 'document_conversion' for inline document conversion tool configurations.<br/>
        /// Default Value: document_conversion
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
        /// Configurable parameters for the document conversion tool. If not overridden, they will be required by the LLM to fill in.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InlineDocumentConversionToolConfiguration(
            string type,
            string? descriptionTemplate,
            global::G.DocumentConversionToolParameters? argumentOverride)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.DescriptionTemplate = descriptionTemplate;
            this.ArgumentOverride = argumentOverride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InlineDocumentConversionToolConfiguration" /> class.
        /// </summary>
        public InlineDocumentConversionToolConfiguration()
        {
        }
    }
}