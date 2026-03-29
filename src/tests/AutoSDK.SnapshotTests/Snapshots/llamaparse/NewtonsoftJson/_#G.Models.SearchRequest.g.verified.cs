//HintName: G.Models.SearchRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request body for searching agent data
    /// </summary>
    public sealed partial class SearchRequest
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
        public global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? Filter { get; set; }

        /// <summary>
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// The agent deployment's name to search within
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("deployment_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string DeploymentName { get; set; } = default!;

        /// <summary>
        /// The logical agent data collection to search within<br/>
        /// Default Value: default
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// Whether to include the total number of items in the response<br/>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("include_total")]
        public bool? IncludeTotal { get; set; }

        /// <summary>
        /// The offset to start from. If not provided, the first page is returned<br/>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        /// <param name="deploymentName">
        /// The agent deployment's name to search within
        /// </param>
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
        /// <param name="collection">
        /// The logical agent data collection to search within<br/>
        /// Default Value: default
        /// </param>
        /// <param name="includeTotal">
        /// Whether to include the total number of items in the response<br/>
        /// Default Value: false
        /// </param>
        /// <param name="offset">
        /// The offset to start from. If not provided, the first page is returned<br/>
        /// Default Value: 0
        /// </param>
        public SearchRequest(
            string deploymentName,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? filter,
            string? orderBy,
            string? collection,
            bool? includeTotal,
            int? offset)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.Filter = filter;
            this.OrderBy = orderBy;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Collection = collection;
            this.IncludeTotal = includeTotal;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRequest" /> class.
        /// </summary>
        public SearchRequest()
        {
        }
    }
}