//HintName: G.Models.GetDocumentProgressOpenAPIRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetDocumentProgressOpenAPIRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("document_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> DocumentIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIRequest" /> class.
        /// </summary>
        /// <param name="documentIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetDocumentProgressOpenAPIRequest(
            global::System.Collections.Generic.IList<string> documentIds)
        {
            this.DocumentIds = documentIds ?? throw new global::System.ArgumentNullException(nameof(documentIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetDocumentProgressOpenAPIRequest" /> class.
        /// </summary>
        public GetDocumentProgressOpenAPIRequest()
        {
        }
    }
}