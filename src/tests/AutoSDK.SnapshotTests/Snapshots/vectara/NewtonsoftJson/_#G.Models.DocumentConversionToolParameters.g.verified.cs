//HintName: G.Models.DocumentConversionToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the document conversion tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class DocumentConversionToolParameters
    {
        /// <summary>
        /// The ID of the artifact to convert.<br/>
        /// Example: art_abc123
        /// </summary>
        /// <example>art_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// Output format for the converted document.<br/>
        /// Example: markdown
        /// </summary>
        /// <example>markdown</example>
        [global::Newtonsoft.Json.JsonProperty("output_format")]
        public global::G.DocumentConversionToolParametersOutputFormat? OutputFormat { get; set; }

        /// <summary>
        /// Optional description for the converted artifact.<br/>
        /// Example: PDF converted to markdown
        /// </summary>
        /// <example>PDF converted to markdown</example>
        [global::Newtonsoft.Json.JsonProperty("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolParameters" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of the artifact to convert.<br/>
        /// Example: art_abc123
        /// </param>
        /// <param name="outputFormat">
        /// Output format for the converted document.<br/>
        /// Example: markdown
        /// </param>
        /// <param name="description">
        /// Optional description for the converted artifact.<br/>
        /// Example: PDF converted to markdown
        /// </param>
        public DocumentConversionToolParameters(
            string? artifactId,
            global::G.DocumentConversionToolParametersOutputFormat? outputFormat,
            string? description)
        {
            this.ArtifactId = artifactId;
            this.OutputFormat = outputFormat;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConversionToolParameters" /> class.
        /// </summary>
        public DocumentConversionToolParameters()
        {
        }
    }
}