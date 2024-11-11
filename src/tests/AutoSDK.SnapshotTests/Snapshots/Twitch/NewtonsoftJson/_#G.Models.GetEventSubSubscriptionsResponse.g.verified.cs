//HintName: G.Models.GetEventSubSubscriptionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetEventSubSubscriptionsResponse
    {
        /// <summary>
        /// The list of subscriptions. The list is ordered by the oldest subscription first. The list is empty if the client hasn't created subscriptions or there are no subscriptions that match the specified filter criteria.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EventSubSubscription> Data { get; set; } = default!;

        /// <summary>
        /// The total number of subscriptions that you've created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCost { get; set; } = default!;

        /// <summary>
        /// The maximum total cost that you're allowed to incur for all subscriptions that you create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxTotalCost { get; set; } = default!;

        /// <summary>
        /// An object that contains the cursor used to get the next page of subscriptions. The object is empty if there are no more pages to get. The number of subscriptions returned per page is undertermined.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pagination")]
        public global::G.GetEventSubSubscriptionsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventSubSubscriptionsResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of subscriptions. The list is ordered by the oldest subscription first. The list is empty if the client hasn't created subscriptions or there are no subscriptions that match the specified filter criteria.
        /// </param>
        /// <param name="total">
        /// The total number of subscriptions that you've created.
        /// </param>
        /// <param name="totalCost">
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </param>
        /// <param name="maxTotalCost">
        /// The maximum total cost that you're allowed to incur for all subscriptions that you create.
        /// </param>
        /// <param name="pagination">
        /// An object that contains the cursor used to get the next page of subscriptions. The object is empty if there are no more pages to get. The number of subscriptions returned per page is undertermined.
        /// </param>
        public GetEventSubSubscriptionsResponse(
            global::System.Collections.Generic.IList<global::G.EventSubSubscription> data,
            int total,
            int totalCost,
            int maxTotalCost,
            global::G.GetEventSubSubscriptionsResponsePagination? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Total = total;
            this.TotalCost = totalCost;
            this.MaxTotalCost = maxTotalCost;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetEventSubSubscriptionsResponse" /> class.
        /// </summary>
        public GetEventSubSubscriptionsResponse()
        {
        }
    }
}