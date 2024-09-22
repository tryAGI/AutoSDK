//HintName: G.Models.CitationOptions.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Options for controlling citation generation.
    /// </summary>
    public sealed partial class CitationOptions
    {
        /// <summary>
        /// Defaults to `"accurate"`.<br/>
        /// Dictates the approach taken to generating citations as part of the RAG flow by allowing the user to specify whether they want `"accurate"` results, `"fast"` results or no results.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("mode")]
        public global::G.CitationOptionsMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}