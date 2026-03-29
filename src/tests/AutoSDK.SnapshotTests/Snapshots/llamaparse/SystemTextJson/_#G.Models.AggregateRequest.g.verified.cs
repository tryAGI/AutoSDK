//HintName: G.Models.AggregateRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// API request body for aggregating agent data
    /// </summary>
    public sealed partial class AggregateRequest
    {
        /// <summary>
        /// The maximum number of items to return. The service may return fewer than this value. If unspecified, a default page size will be used. The maximum value is typically 1000; values above this will be coerced to the maximum.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_size")]
        public int? PageSize { get; set; }

        /// <summary>
        /// A page token, received from a previous list call. Provide this to retrieve the subsequent page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("page_token")]
        public string? PageToken { get; set; }

        /// <summary>
        /// A filter object or expression that filters resources listed in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filter")]
        public global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? Filter { get; set; }

        /// <summary>
        /// A comma-separated list of fields to order by, sorted in ascending order. Use 'field_name desc' to specify descending order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("order_by")]
        public string? OrderBy { get; set; }

        /// <summary>
        /// The agent deployment's name to aggregate data for
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// The logical agent data collection to aggregate data for<br/>
        /// Default Value: default
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// The fields to group by. If empty, the entire dataset is grouped on. e.g. if left out, can be used for simple count operations
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group_by")]
        public global::System.Collections.Generic.IList<string>? GroupBy { get; set; }

        /// <summary>
        /// Whether to count the number of items in each group<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("count")]
        public bool? Count { get; set; }

        /// <summary>
        /// Whether to return the first item in each group (Sorted by created_at)<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first")]
        public bool? First { get; set; }

        /// <summary>
        /// The offset to start from. If not provided, the first page is returned<br/>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset")]
        public int? Offset { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateRequest" /> class.
        /// </summary>
        /// <param name="deploymentName">
        /// The agent deployment's name to aggregate data for
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
        /// The logical agent data collection to aggregate data for<br/>
        /// Default Value: default
        /// </param>
        /// <param name="groupBy">
        /// The fields to group by. If empty, the entire dataset is grouped on. e.g. if left out, can be used for simple count operations
        /// </param>
        /// <param name="count">
        /// Whether to count the number of items in each group<br/>
        /// Default Value: false
        /// </param>
        /// <param name="first">
        /// Whether to return the first item in each group (Sorted by created_at)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="offset">
        /// The offset to start from. If not provided, the first page is returned<br/>
        /// Default Value: 0
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AggregateRequest(
            string deploymentName,
            int? pageSize,
            string? pageToken,
            global::System.Collections.Generic.Dictionary<string, global::G.FilterOperation>? filter,
            string? orderBy,
            string? collection,
            global::System.Collections.Generic.IList<string>? groupBy,
            bool? count,
            bool? first,
            int? offset)
        {
            this.PageSize = pageSize;
            this.PageToken = pageToken;
            this.Filter = filter;
            this.OrderBy = orderBy;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Collection = collection;
            this.GroupBy = groupBy;
            this.Count = count;
            this.First = first;
            this.Offset = offset;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AggregateRequest" /> class.
        /// </summary>
        public AggregateRequest()
        {
        }
    }
}