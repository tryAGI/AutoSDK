//HintName: G.Models.UserSubscription.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// UserSubscription details describe the plan (i.e., features) a user has access to.
    /// </summary>
    public sealed partial class UserSubscription
    {
        /// <summary>
        /// StripeSubscriptionDetail describes the details of a subscription in Stripe.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Enumerates the plan types for the user subscription.<br/>
        ///  - PLAN_FREE: Free plan.<br/>
        ///  - PLAN_PRO: Pro plan.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.UserSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}