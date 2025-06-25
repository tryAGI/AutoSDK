//HintName: G.Models.CorpusUploadsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CorpusUploadsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DocumentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("presignedUrl")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PresignedUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsResponse" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="presignedUrl"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CorpusUploadsResponse(
            string documentId,
            string presignedUrl)
        {
            this.DocumentId = documentId ?? throw new global::System.ArgumentNullException(nameof(documentId));
            this.PresignedUrl = presignedUrl ?? throw new global::System.ArgumentNullException(nameof(presignedUrl));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsResponse" /> class.
        /// </summary>
        public CorpusUploadsResponse()
        {
        }
    }
}