//HintName: G.Models.CitationSource.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// A citation to a source for a portion of a specific response.
    /// </summary>
    public sealed partial class CitationSource
    {
        /// <summary>
        /// Optional. License for the GitHub project that is attributed as a source for segment. License info is required for code citations.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// Optional. URI that is attributed as a source for a portion of the text.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uri")]
        public string? Uri { get; set; }

        /// <summary>
        /// Optional. End of the attributed segment, exclusive.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("endIndex")]
        public int? EndIndex { get; set; }

        /// <summary>
        /// Optional. Start of segment of the response that is attributed to this source. Index indicates the start of the segment, measured in bytes.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("startIndex")]
        public int? StartIndex { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}