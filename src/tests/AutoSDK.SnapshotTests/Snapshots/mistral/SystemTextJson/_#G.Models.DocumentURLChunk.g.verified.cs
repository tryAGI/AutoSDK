//HintName: G.Models.DocumentURLChunk.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentURLChunk
    {
        /// <summary>
        /// The filename of the document
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentUrl { get; set; }

        /// <summary>
        /// Default Value: document_url
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.DocumentURLChunkTypeJsonConverter))]
        public global::G.DocumentURLChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentURLChunk" /> class.
        /// </summary>
        /// <param name="documentName">
        /// The filename of the document
        /// </param>
        /// <param name="documentUrl"></param>
        /// <param name="type">
        /// Default Value: document_url
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentURLChunk(
            string documentUrl,
            string? documentName,
            global::G.DocumentURLChunkType? type)
        {
            this.DocumentUrl = documentUrl ?? throw new global::System.ArgumentNullException(nameof(documentUrl));
            this.DocumentName = documentName;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentURLChunk" /> class.
        /// </summary>
        public DocumentURLChunk()
        {
        }
    }
}