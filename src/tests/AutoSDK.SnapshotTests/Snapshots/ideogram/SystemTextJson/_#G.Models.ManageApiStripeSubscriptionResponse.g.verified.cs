//HintName: G.Models.ManageApiStripeSubscriptionResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageApiStripeSubscriptionResponse
    {
        /// <summary>
        /// The URL for the user to checkout the Stripe subscription plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_subscription_url")]
        public string? StripeSubscriptionUrl { get; set; }

        /// <summary>
        /// DEPRECATED. The URL for the user to manage the existing Stripe subscription plan. Get this from ManageApiSubscriptionResponse instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_billing_url")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? StripeBillingUrl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiStripeSubscriptionResponse" /> class.
        /// </summary>
        /// <param name="stripeSubscriptionUrl">
        /// The URL for the user to checkout the Stripe subscription plan.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public ManageApiStripeSubscriptionResponse(
            string? stripeSubscriptionUrl)
        {
            this.StripeSubscriptionUrl = stripeSubscriptionUrl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageApiStripeSubscriptionResponse" /> class.
        /// </summary>
        public ManageApiStripeSubscriptionResponse()
        {
        }
    }
}