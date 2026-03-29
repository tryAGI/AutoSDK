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
        [global::Newtonsoft.Json.JsonProperty("documents", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.CloudDocument> Documents { get; set; } = default!;

        /// <summary>
        /// The limit of the documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public int Limit { get; set; } = default!;

        /// <summary>
        /// The offset of the documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset", Required = global::Newtonsoft.Json.Required.Always)]
        public int Offset { get; set; } = default!;

        /// <summary>
        /// The total number of documents
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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