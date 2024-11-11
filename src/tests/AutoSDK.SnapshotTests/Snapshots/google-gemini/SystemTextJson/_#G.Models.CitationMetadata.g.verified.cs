//HintName: G.Models.CitationMetadata.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A collection of source attributions for a piece of content.
    /// </summary>
    public sealed partial class CitationMetadata
    {
        /// <summary>
        /// Citations to sources for a specific response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("citationSources")]
        public global::System.Collections.Generic.IList<global::G.CitationSource>? CitationSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationMetadata" /> class.
        /// </summary>
        /// <param name="citationSources">
        /// Citations to sources for a specific response.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CitationMetadata(
            global::System.Collections.Generic.IList<global::G.CitationSource>? citationSources)
        {
            this.CitationSources = citationSources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationMetadata" /> class.
        /// </summary>
        public CitationMetadata()
        {
        }
    }
}