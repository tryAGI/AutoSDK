//HintName: G.Models.DocumentStorageUsage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// How much storage the document used. This information is currently not returned when<br/>
    /// retrieving the document, and only returned when indexing a document.
    /// </summary>
    public sealed partial class DocumentStorageUsage
    {
        /// <summary>
        /// Number of bytes used by document counting towards maximum corpus size, and<br/>
        /// towards any billing plans.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bytes_used")]
        public long? BytesUsed { get; set; }

        /// <summary>
        /// Number of metadata bytes used by a document.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_bytes_used")]
        public long? MetadataBytesUsed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStorageUsage" /> class.
        /// </summary>
        /// <param name="bytesUsed">
        /// Number of bytes used by document counting towards maximum corpus size, and<br/>
        /// towards any billing plans.
        /// </param>
        /// <param name="metadataBytesUsed">
        /// Number of metadata bytes used by a document.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentStorageUsage(
            long? bytesUsed,
            long? metadataBytesUsed)
        {
            this.BytesUsed = bytesUsed;
            this.MetadataBytesUsed = metadataBytesUsed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentStorageUsage" /> class.
        /// </summary>
        public DocumentStorageUsage()
        {
        }
    }
}