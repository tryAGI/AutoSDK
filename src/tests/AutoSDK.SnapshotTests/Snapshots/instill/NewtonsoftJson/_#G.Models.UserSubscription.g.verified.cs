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
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.UserSubscriptionPlan? Plan { get; set; }

        /// <summary>
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("detail")]
        public global::G.StripeSubscriptionDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        /// <param name="plan">
        /// Plan identifier.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="detail">
        /// Details of the associated Stripe subscription.<br/>
        /// Included only in responses
        /// </param>
        public UserSubscription(
            global::G.UserSubscriptionPlan? plan,
            global::G.StripeSubscriptionDetail? detail)
        {
            this.Plan = plan;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserSubscription" /> class.
        /// </summary>
        public UserSubscription()
        {
        }
    }
}