//HintName: G.Models.UpdateDocumentRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateDocumentRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_name")]
        public string? DocumentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tags")]
        public global::System.Collections.Generic.IList<string>? Tags { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        /// <param name="documentName"></param>
        /// <param name="tags"></param>
        public UpdateDocumentRequest(
            string? documentName,
            global::System.Collections.Generic.IList<string>? tags)
        {
            this.DocumentName = documentName;
            this.Tags = tags;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateDocumentRequest" /> class.
        /// </summary>
        public UpdateDocumentRequest()
        {
        }
    }
}