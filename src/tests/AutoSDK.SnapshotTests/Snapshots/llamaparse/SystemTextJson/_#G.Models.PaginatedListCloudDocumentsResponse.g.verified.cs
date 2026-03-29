//HintName: G.Models.PaginatedListCloudDocumentsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginatedListCloudDocumentsResponse
    {
        /// <summary>
        /// The documents to list
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.CloudDocument> Documents { get; set; }

        /// <summary>
        /// The limit of the documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Limit { get; set; }

        /// <summary>
        /// The offset of the documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Offset { get; set; }

        /// <summary>
        /// The total number of documents
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListCloudDocumentsResponse" /> class.
        /// </summary>
        /// <param name="documents">
        /// The documents to list
        /// </param>
        /// <param name="limit">
        /// The limit of the documents
        /// </param>
        /// <param name="offset">
        /// The offset of the documents
        /// </param>
        /// <param name="totalCount">
        /// The total number of documents
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginatedListCloudDocumentsResponse(
            global::System.Collections.Generic.IList<global::G.CloudDocument> documents,
            int limit,
            int offset,
            int totalCount)
        {
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Limit = limit;
            this.Offset = offset;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedListCloudDocumentsResponse" /> class.
        /// </summary>
        public PaginatedListCloudDocumentsResponse()
        {
        }
    }
}