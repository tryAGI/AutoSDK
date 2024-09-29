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
        [global::Newtonsoft.Json.JsonProperty("citationSources")]
        public global::System.Collections.Generic.IList<global::G.CitationSource>? CitationSources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}