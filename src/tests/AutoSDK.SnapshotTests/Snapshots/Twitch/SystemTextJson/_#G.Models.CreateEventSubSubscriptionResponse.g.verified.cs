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
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.EventSubSubscription> Data { get; set; }

        /// <summary>
        /// The total number of subscriptions you’ve created.
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
        /// The maximum total cost that you’re allowed to incur for all subscriptions you create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MaxTotalCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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