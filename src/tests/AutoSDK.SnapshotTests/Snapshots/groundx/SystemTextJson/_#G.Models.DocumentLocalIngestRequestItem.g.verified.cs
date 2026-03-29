//HintName: G.Models.DocumentLocalIngestRequestItem.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentLocalIngestRequestItem
    {
        /// <summary>
        /// The actual file being ingested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blob")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required byte[] Blob { get; set; }

        /// <summary>
        /// The actual file being ingested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blobname")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Blobname { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.DocumentLocalIngestRequestItemMetadata Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLocalIngestRequestItem" /> class.
        /// </summary>
        /// <param name="blob">
        /// The actual file being ingested.
        /// </param>
        /// <param name="blobname">
        /// The actual file being ingested.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentLocalIngestRequestItem(
            byte[] blob,
            string blobname,
            global::G.DocumentLocalIngestRequestItemMetadata metadata)
        {
            this.Blob = blob ?? throw new global::System.ArgumentNullException(nameof(blob));
            this.Blobname = blobname ?? throw new global::System.ArgumentNullException(nameof(blobname));
            this.Metadata = metadata ?? throw new global::System.ArgumentNullException(nameof(metadata));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentLocalIngestRequestItem" /> class.
        /// </summary>
        public DocumentLocalIngestRequestItem()
        {
        }
    }
}