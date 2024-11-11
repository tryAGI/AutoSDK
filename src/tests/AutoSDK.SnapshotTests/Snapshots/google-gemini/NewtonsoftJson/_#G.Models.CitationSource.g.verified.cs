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

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationSource" /> class.
        /// </summary>
        /// <param name="license">
        /// Optional. License for the GitHub project that is attributed as a source for segment. License info is required for code citations.
        /// </param>
        /// <param name="uri">
        /// Optional. URI that is attributed as a source for a portion of the text.
        /// </param>
        /// <param name="endIndex">
        /// Optional. End of the attributed segment, exclusive.
        /// </param>
        /// <param name="startIndex">
        /// Optional. Start of segment of the response that is attributed to this source. Index indicates the start of the segment, measured in bytes.
        /// </param>
        public CitationSource(
            string? license,
            string? uri,
            int? endIndex,
            int? startIndex)
        {
            this.License = license;
            this.Uri = uri;
            this.EndIndex = endIndex;
            this.StartIndex = startIndex;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CitationSource" /> class.
        /// </summary>
        public CitationSource()
        {
        }
    }
}