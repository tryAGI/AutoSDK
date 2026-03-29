//HintName: G.Models.ListDocumentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Response from `ListDocuments` containing a paginated list of `Document`s. The `Document`s are sorted by ascending `document.create_time`.
    /// </summary>
    public sealed partial class ListDocumentsResponse
    {
        /// <summary>
        /// The returned `Document`s.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        public global::System.Collections.Generic.IList<global::G.Document>? Documents { get; set; }

        /// <summary>
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nextPageToken")]
        public string? NextPageToken { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents">
        /// The returned `Document`s.
        /// </param>
        /// <param name="nextPageToken">
        /// A token, which can be sent as `page_token` to retrieve the next page. If this field is omitted, there are no more pages.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListDocumentsResponse(
            global::System.Collections.Generic.IList<global::G.Document>? documents,
            string? nextPageToken)
        {
            this.Documents = documents;
            this.NextPageToken = nextPageToken;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListDocumentsResponse" /> class.
        /// </summary>
        public ListDocumentsResponse()
        {
        }
    }
}