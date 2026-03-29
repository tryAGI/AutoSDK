//HintName: G.Models.FileQueryRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Request schema for querying files with pagination and filtering.
    /// </summary>
    public sealed partial class FileQueryRequest
    {
        /// <summary>
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// A filter object or expression that filters resources listed in the response.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("filter")]
        public global::G.FileFilter? Filter { get; set; }

        /// <summary>
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FileQueryRequest" /> class.
        /// </summary>
        /// <param name="pageSize">
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </param>
        /// <param name="pageToken">
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </param>
        /// <param name="filter">
        /// A filter object or expression that filters resources listed in the response.
        /// </param>
        /// <param name="orderBy">
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </param>
        public FileQueryRequest(
            int? pageSize,
            string? pageToken,
            global::G.FileFilter? filter,
            string? orderBy)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.Filter = filter;
            this.OrderBy = orderBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileQueryRequest" /> class.
        /// </summary>
        public FileQueryRequest()
        {
        }
    }
}