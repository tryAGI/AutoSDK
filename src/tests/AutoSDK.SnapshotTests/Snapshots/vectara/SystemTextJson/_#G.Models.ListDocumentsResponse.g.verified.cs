//HintName: G.Models.ListDocumentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response containing a list of documents stored in a corpus.
    /// </summary>
    public sealed partial class ListDocumentsResponse
    {
        /// <summary>
        /// List of documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.Document>? Documents { get; set; }

        /// <summary>
        /// The standard metadata in the response of a list operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::G.ListMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents">
        /// List of documents.
        /// </param>
        /// <param name="metadata">
        /// The standard metadata in the response of a list operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDocumentsResponse(
            global::System.Collections.Generic.IList<global::G.Document>? documents,
            global::G.ListMetadata? metadata)
        {
            this.Documents = documents;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        public ListDocumentsResponse()
        {
        }
    }
}