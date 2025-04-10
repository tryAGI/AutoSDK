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
        [global::Newtonsoft.Json.JsonProperty("documentId", Required = global::Newtonsoft.Json.Required.Always)]
        public string DocumentId { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("presignedUrl", Required = global::Newtonsoft.Json.Required.Always)]
        public string PresignedUrl { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CorpusUploadsResponse" /> class.
        /// </summary>
        /// <param name="documentId"></param>
        /// <param name="presignedUrl"></param>
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