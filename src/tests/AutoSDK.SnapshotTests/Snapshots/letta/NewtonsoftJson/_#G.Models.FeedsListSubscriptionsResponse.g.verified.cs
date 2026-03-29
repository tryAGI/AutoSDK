//HintName: G.Models.FeedsListSubscriptionsResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class FeedsListSubscriptionsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscriptions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.FeedsListSubscriptionsResponseSubscription> Subscriptions { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("has_next_page", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasNextPage { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionsResponse" /> class.
        /// </summary>
        /// <param name="subscriptions"></param>
        /// <param name="hasNextPage"></param>
        public FeedsListSubscriptionsResponse(
            global::System.Collections.Generic.IList<global::G.FeedsListSubscriptionsResponseSubscription> subscriptions,
            bool hasNextPage)
        {
            this.Subscriptions = subscriptions ?? throw new global::System.ArgumentNullException(nameof(subscriptions));
            this.HasNextPage = hasNextPage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionsResponse" /> class.
        /// </summary>
        public FeedsListSubscriptionsResponse()
        {
        }
    }
}