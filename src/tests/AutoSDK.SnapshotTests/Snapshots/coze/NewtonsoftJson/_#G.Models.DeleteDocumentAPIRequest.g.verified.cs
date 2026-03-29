//HintName: G.Models.DeleteDocumentAPIRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DeleteDocumentAPIRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("document_ids", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> DocumentIds { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentAPIRequest" /> class.
        /// </summary>
        /// <param name="documentIds"></param>
        public DeleteDocumentAPIRequest(
            global::System.Collections.Generic.IList<string> documentIds)
        {
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteDocumentAPIRequest" /> class.
        /// </summary>
        public DeleteDocumentAPIRequest()
        {
        }
    }
}