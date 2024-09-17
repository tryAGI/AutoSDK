//HintName: G.Models.UserSubscription.g.cs

#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// UserSubscription details describe the plan (i.e., features) a user has access to.
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// Plan identifier.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.AllOf<global::G.UserSubscriptionPlan?>? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.AllOf<global::G.StripeSubscriptionDetail>? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}