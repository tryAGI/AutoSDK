//HintName: G.Models.DocumentStorageUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much storage the document used. This information is currently not returned when<br/>
    /// retrieving the document, and only returned when indexing document.
    /// </summary>
    public sealed partial class DocumentStorageUsage
    {
        /// <summary>
        /// Number of bytes used by document counting towards maximum corpus size, and<br/>
        /// towards any billing plans.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bytes_used")]
        public long? BytesUsed { get; set; }

        /// <summary>
        /// Number of metadata bytes used by document metadata.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("metadata_bytes_used")]
        public long? MetadataBytesUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}