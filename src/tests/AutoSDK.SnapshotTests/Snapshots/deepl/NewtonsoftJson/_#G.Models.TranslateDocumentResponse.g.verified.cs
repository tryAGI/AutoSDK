//HintName: G.Models.TranslateDocumentResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TranslateDocumentResponse
    {
        /// <summary>
        /// A unique ID assigned to the uploaded document and the translation process. Must be used when referring to this particular document in subsequent API requests.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_id")]
        public string? DocumentId { get; set; }

        /// <summary>
        /// A unique key that is used to encrypt the uploaded document as well as the resulting translation on the server side. Must be provided with every subsequent API request regarding this particular document.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_key")]
        public string? DocumentKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentResponse" /> class.
        /// </summary>
        /// <param name="documentId">
        /// A unique ID assigned to the uploaded document and the translation process. Must be used when referring to this particular document in subsequent API requests.
        /// </param>
        /// <param name="documentKey">
        /// A unique key that is used to encrypt the uploaded document as well as the resulting translation on the server side. Must be provided with every subsequent API request regarding this particular document.
        /// </param>
        public TranslateDocumentResponse(
            string? documentId,
            string? documentKey)
        {
            this.DocumentId = documentId;
            this.DocumentKey = documentKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateDocumentResponse" /> class.
        /// </summary>
        public TranslateDocumentResponse()
        {
        }
    }
}