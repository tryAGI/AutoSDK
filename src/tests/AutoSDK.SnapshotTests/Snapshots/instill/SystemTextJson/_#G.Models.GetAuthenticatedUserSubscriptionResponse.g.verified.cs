//HintName: G.Models.GetAuthenticatedUserSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetAuthenticatedUserSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetAuthenticatedUserSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subscription")]
        public global::G.UserSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}