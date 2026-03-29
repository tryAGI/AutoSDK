//HintName: G.IApi.ListCalls.g.cs
#nullable enable

namespace G
{
    public partial interface IApi
    {
        /// <summary>
        /// Retrieve call details
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::G.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.V2CallResponse>> ListCallsAsync(

            global::G.ListCallsRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve call details
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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::G.V2CallResponse>> ListCallsAsync(
            global::G.ListCallsRequestFilterCriteria? filterCriteria = default,
            global::G.ListCallsRequestSortOrder? sortOrder = default,
            int? limit = default,
            string? paginationKey = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}