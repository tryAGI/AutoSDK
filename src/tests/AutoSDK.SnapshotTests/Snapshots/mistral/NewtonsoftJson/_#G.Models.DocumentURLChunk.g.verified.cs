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
        [global::Newtonsoft.Json.JsonProperty("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentUrl { get; set; } = default!;

        /// <summary>
        /// Default Value: document_url
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("type")]
        public global::G.DocumentURLChunkType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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