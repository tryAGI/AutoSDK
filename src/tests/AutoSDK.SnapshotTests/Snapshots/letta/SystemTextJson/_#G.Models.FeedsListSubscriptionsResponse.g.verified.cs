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
        [global::System.Text.Json.Serialization.JsonPropertyName("subscriptions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.FeedsListSubscriptionsResponseSubscription> Subscriptions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_next_page")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasNextPage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="FeedsListSubscriptionsResponse" /> class.
        /// </summary>
        /// <param name="subscriptions"></param>
        /// <param name="hasNextPage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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