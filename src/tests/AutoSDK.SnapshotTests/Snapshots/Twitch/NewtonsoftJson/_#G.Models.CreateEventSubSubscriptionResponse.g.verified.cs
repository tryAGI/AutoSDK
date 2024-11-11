//HintName: G.Models.CreateEventSubSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEventSubSubscriptionResponse
    {
        /// <summary>
        /// A list that contains the single subscription that you created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("data", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.EventSubSubscription> Data { get; set; } = default!;

        /// <summary>
        /// The total number of subscriptions you’ve created.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public int Total { get; set; } = default!;

        /// <summary>
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int TotalCost { get; set; } = default!;

        /// <summary>
        /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("max_total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public int MaxTotalCost { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// A list that contains the single subscription that you created.
        /// </param>
        /// <param name="total">
        /// The total number of subscriptions you’ve created.
        /// </param>
        /// <param name="totalCost">
        /// The sum of all of your subscription costs. [Learn More](https://dev.twitch.tv/docs/eventsub/manage-subscriptions/#subscription-limits)
        /// </param>
        /// <param name="maxTotalCost">
        /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
        /// </param>
        public CreateEventSubSubscriptionResponse(
            global::System.Collections.Generic.IList<global::G.EventSubSubscription> data,
            int total,
            int totalCost,
            int maxTotalCost)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Total = total;
            this.TotalCost = totalCost;
            this.MaxTotalCost = maxTotalCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventSubSubscriptionResponse" /> class.
        /// </summary>
        public CreateEventSubSubscriptionResponse()
        {
        }
    }
}