//HintName: G.Models.ListCallsRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ListCallsRequest
    {
        /// <summary>
        /// Filter criteria for the calls to retrieve.<br/>
        /// Example: {"call_id":["call_5a82f0a43ea0977566b1104fcfc"],"agent_id":["agent_oBeDLoLOeuAbiuaMFXRtDOLriT12345"],"call_status":["ended"],"call_type":["phone_call"],"direction":["inbound"],"user_sentiment":["Positive"],"call_successful":[true],"start_timestamp":{"upper_threshold":1738475421000,"lower_threshold":1738475411000},"metadata.customer_id":["cust_123"],"dynamic_variables.user_name":["John"]}
        /// </summary>
        /// <example>{"call_id":["call_5a82f0a43ea0977566b1104fcfc"],"agent_id":["agent_oBeDLoLOeuAbiuaMFXRtDOLriT12345"],"call_status":["ended"],"call_type":["phone_call"],"direction":["inbound"],"user_sentiment":["Positive"],"call_successful":[true],"start_timestamp":{"upper_threshold":1738475421000,"lower_threshold":1738475411000},"metadata.customer_id":["cust_123"],"dynamic_variables.user_name":["John"]}</example>
        [global::Newtonsoft.Json.JsonProperty("filter_criteria")]
        public global::G.ListCallsRequestFilterCriteria? FilterCriteria { get; set; }

        /// <summary>
        /// The calls will be sorted by `start_timestamp`, whether to return the calls in ascending or descending order.<br/>
        /// Default Value: descending
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("sort_order")]
        public global::G.ListCallsRequestSortOrder? SortOrder { get; set; }

        /// <summary>
        /// Limit the number of calls returned. Default 50, Max 1000. To retrieve more than 1000, use pagination_key to continue fetching the next page.<br/>
        /// Default Value: 50
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// The pagination key to continue fetching the next page of calls. Pagination key is represented by a call id here, and it's exclusive (not included in the fetched calls). The last call id from the list calls is usually used as pagination key here. If not set, will start from the beginning.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination_key")]
        public string? PaginationKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequest" /> class.
        /// </summary>
        /// <param name="filterCriteria">
        /// Filter criteria for the calls to retrieve.<br/>
        /// Example: {"call_id":["call_5a82f0a43ea0977566b1104fcfc"],"agent_id":["agent_oBeDLoLOeuAbiuaMFXRtDOLriT12345"],"call_status":["ended"],"call_type":["phone_call"],"direction":["inbound"],"user_sentiment":["Positive"],"call_successful":[true],"start_timestamp":{"upper_threshold":1738475421000,"lower_threshold":1738475411000},"metadata.customer_id":["cust_123"],"dynamic_variables.user_name":["John"]}
        /// </param>
        /// <param name="sortOrder">
        /// The calls will be sorted by `start_timestamp`, whether to return the calls in ascending or descending order.<br/>
        /// Default Value: descending
        /// </param>
        /// <param name="limit">
        /// Limit the number of calls returned. Default 50, Max 1000. To retrieve more than 1000, use pagination_key to continue fetching the next page.<br/>
        /// Default Value: 50
        /// </param>
        /// <param name="paginationKey">
        /// The pagination key to continue fetching the next page of calls. Pagination key is represented by a call id here, and it's exclusive (not included in the fetched calls). The last call id from the list calls is usually used as pagination key here. If not set, will start from the beginning.
        /// </param>
        public ListCallsRequest(
            global::G.ListCallsRequestFilterCriteria? filterCriteria,
            global::G.ListCallsRequestSortOrder? sortOrder,
            int? limit,
            string? paginationKey)
        {
            this.FilterCriteria = filterCriteria;
            this.SortOrder = sortOrder;
            this.Limit = limit;
            this.PaginationKey = paginationKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListCallsRequest" /> class.
        /// </summary>
        public ListCallsRequest()
        {
        }
    }
}