//HintName: G.Models.GetAuthenticatedUserSubscriptionResponse.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// GetAuthenticatedUserSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetAuthenticatedUserSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription")]
        public global::G.AllOf<global::G.UserSubscription>? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}