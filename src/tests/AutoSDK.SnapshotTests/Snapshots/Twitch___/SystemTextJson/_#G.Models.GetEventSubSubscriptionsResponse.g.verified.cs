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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EventSubSubscription> Data { get; set; }

        /// <summary>
        /// The total number of subscriptions that you've created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Total { get; set; }

        /// <summary>
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCost { get; set; }

        /// <summary>
        /// The maximum total cost that you're allowed to incur for all subscriptions that you create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTotalCost { get; set; }

        /// <summary>
        /// An object that contains the cursor used to get the next page of subscriptions. The object is empty if there are no more pages to get. The number of subscriptions returned per page is undertermined.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::G.GetEventSubSubscriptionsResponsePagination? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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