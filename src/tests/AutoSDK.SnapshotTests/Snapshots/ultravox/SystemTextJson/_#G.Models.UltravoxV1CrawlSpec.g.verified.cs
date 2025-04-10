//HintName: G.Models.UltravoxV1CrawlSpec.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The specification of how to acquire documents for this source.
    /// </summary>
    public sealed partial class UltravoxV1CrawlSpec
    {
        /// <summary>
        /// The maximum number of documents to ingest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDocuments")]
        public int? MaxDocuments { get; set; }

        /// <summary>
        /// The maximum size of an individual document in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDocumentBytes")]
        public int? MaxDocumentBytes { get; set; }

        /// <summary>
        /// The types of documents to keep. Any documents surfaced during loading<br/>
        ///  that don't match this filter will be discarded. If not set, Ultravox will<br/>
        ///  choose a default that includes types known to provide real value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("relevantDocumentTypes")]
        public global::G.UltravoxV1MimeTypeFilter? RelevantDocumentTypes { get; set; }

        /// <summary>
        /// The list of start URLs for crawling. If max_depth is 1, only these URLs will<br/>
        ///  be fetched. Otherwise, links from these urls will be followed up to the<br/>
        ///  max_depth.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startUrls")]
        public global::System.Collections.Generic.IList<string>? StartUrls { get; set; }

        /// <summary>
        /// The maximum depth of links to traverse. Use 1 to only fetch the startUrls,<br/>
        ///  2 to fetch the startUrls and documents directly linked from them, 3 to<br/>
        ///  additionally fetch documents linked from those (excluding anything already<br/>
        ///  seen), etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxDepth")]
        public int? MaxDepth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CrawlSpec" /> class.
        /// </summary>
        /// <param name="maxDocuments">
        /// The maximum number of documents to ingest.
        /// </param>
        /// <param name="maxDocumentBytes">
        /// The maximum size of an individual document in bytes.
        /// </param>
        /// <param name="relevantDocumentTypes">
        /// The types of documents to keep. Any documents surfaced during loading<br/>
        ///  that don't match this filter will be discarded. If not set, Ultravox will<br/>
        ///  choose a default that includes types known to provide real value.
        /// </param>
        /// <param name="startUrls">
        /// The list of start URLs for crawling. If max_depth is 1, only these URLs will<br/>
        ///  be fetched. Otherwise, links from these urls will be followed up to the<br/>
        ///  max_depth.
        /// </param>
        /// <param name="maxDepth">
        /// The maximum depth of links to traverse. Use 1 to only fetch the startUrls,<br/>
        ///  2 to fetch the startUrls and documents directly linked from them, 3 to<br/>
        ///  additionally fetch documents linked from those (excluding anything already<br/>
        ///  seen), etc.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltravoxV1CrawlSpec(
            int? maxDocuments,
            int? maxDocumentBytes,
            global::G.UltravoxV1MimeTypeFilter? relevantDocumentTypes,
            global::System.Collections.Generic.IList<string>? startUrls,
            int? maxDepth)
        {
            this.MaxDocuments = maxDocuments;
            this.MaxDocumentBytes = maxDocumentBytes;
            this.RelevantDocumentTypes = relevantDocumentTypes;
            this.StartUrls = startUrls;
            this.MaxDepth = maxDepth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltravoxV1CrawlSpec" /> class.
        /// </summary>
        public UltravoxV1CrawlSpec()
        {
        }
    }
}