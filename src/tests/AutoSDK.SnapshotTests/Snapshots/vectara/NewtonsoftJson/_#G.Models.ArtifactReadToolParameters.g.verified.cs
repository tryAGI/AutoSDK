//HintName: G.Models.ArtifactReadToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the artifact read tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class ArtifactReadToolParameters
    {
        /// <summary>
        /// The ID of the artifact to read.<br/>
        /// Example: art_abc123
        /// </summary>
        /// <example>art_abc123</example>
        [global::Newtonsoft.Json.JsonProperty("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// The encoding format for the content.<br/>
        /// Example: raw
        /// </summary>
        /// <example>raw</example>
        [global::Newtonsoft.Json.JsonProperty("encoding")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ArtifactReadToolParametersEncodingJsonConverter))]
        public global::G.ArtifactReadToolParametersEncoding? Encoding { get; set; }

        /// <summary>
        /// Optional starting line number (1-indexed).<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("start_line")]
        public int? StartLine { get; set; }

        /// <summary>
        /// Optional ending line number (1-indexed, inclusive).<br/>
        /// Example: 200
        /// </summary>
        /// <example>200</example>
        [global::Newtonsoft.Json.JsonProperty("end_line")]
        public int? EndLine { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadToolParameters" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of the artifact to read.<br/>
        /// Example: art_abc123
        /// </param>
        /// <param name="encoding">
        /// The encoding format for the content.<br/>
        /// Example: raw
        /// </param>
        /// <param name="startLine">
        /// Optional starting line number (1-indexed).<br/>
        /// Example: 100
        /// </param>
        /// <param name="endLine">
        /// Optional ending line number (1-indexed, inclusive).<br/>
        /// Example: 200
        /// </param>
        public ArtifactReadToolParameters(
            string? artifactId,
            global::G.ArtifactReadToolParametersEncoding? encoding,
            int? startLine,
            int? endLine)
        {
            this.ArtifactId = artifactId;
            this.Encoding = encoding;
            this.StartLine = startLine;
            this.EndLine = endLine;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactReadToolParameters" /> class.
        /// </summary>
        public ArtifactReadToolParameters()
        {
        }
    }
}