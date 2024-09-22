//HintName: G.Models.GetOrganizationSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// GetOrganizationSubscriptionResponse contains the requested subscription.
    /// </summary>
    public sealed partial class GetOrganizationSubscriptionResponse
    {
        /// <summary>
        /// The subscription resource.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subscription")]
        public global::G.OrganizationSubscription? Subscription { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}