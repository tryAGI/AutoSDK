//HintName: G.Models.OrganizationSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// OrganizationSubscription details describe the plan (i.e., features) an organization has access to.
    /// </summary>
    public sealed partial class OrganizationSubscription
    {
        /// <summary>
        /// Plan identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.OrganizationSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Number of used seats within the organization subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usedSeats")]
        public int? UsedSeats { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}