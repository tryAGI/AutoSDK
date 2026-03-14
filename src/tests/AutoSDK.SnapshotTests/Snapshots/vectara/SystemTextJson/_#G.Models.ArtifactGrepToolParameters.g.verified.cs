//HintName: G.Models.ArtifactGrepToolParameters.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Configurable parameters for the artifact grep tool. If not overridden, they will be required by the LLM to fill in.
    /// </summary>
    public sealed partial class ArtifactGrepToolParameters
    {
        /// <summary>
        /// The ID of the artifact to search.<br/>
        /// Example: art_abc123
        /// </summary>
        /// <example>art_abc123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("artifact_id")]
        public string? ArtifactId { get; set; }

        /// <summary>
        /// The pattern to search for (supports grep regex).<br/>
        /// Example: error|exception
        /// </summary>
        /// <example>error|exception</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pattern")]
        public string? Pattern { get; set; }

        /// <summary>
        /// Optional grep command options.<br/>
        /// Example: [-i, -n]
        /// </summary>
        /// <example>[-i, -n]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("grep_options")]
        public global::System.Collections.Generic.IList<string>? GrepOptions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolParameters" /> class.
        /// </summary>
        /// <param name="artifactId">
        /// The ID of the artifact to search.<br/>
        /// Example: art_abc123
        /// </param>
        /// <param name="pattern">
        /// The pattern to search for (supports grep regex).<br/>
        /// Example: error|exception
        /// </param>
        /// <param name="grepOptions">
        /// Optional grep command options.<br/>
        /// Example: [-i, -n]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArtifactGrepToolParameters(
            string? artifactId,
            string? pattern,
            global::System.Collections.Generic.IList<string>? grepOptions)
        {
            this.ArtifactId = artifactId;
            this.Pattern = pattern;
            this.GrepOptions = grepOptions;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArtifactGrepToolParameters" /> class.
        /// </summary>
        public ArtifactGrepToolParameters()
        {
        }
    }
}