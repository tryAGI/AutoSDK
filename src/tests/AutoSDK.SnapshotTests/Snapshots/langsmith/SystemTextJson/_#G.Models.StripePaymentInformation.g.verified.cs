//HintName: G.Models.StripePaymentInformation.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Stripe payment information.
    /// </summary>
    public sealed partial class StripePaymentInformation
    {
        /// <summary>
        /// Stripe customer billing information.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_info")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.StripeCustomerBillingInfo BillingInfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("setup_intent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SetupIntent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentInformation" /> class.
        /// </summary>
        /// <param name="billingInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="setupIntent"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StripePaymentInformation(
            global::G.StripeCustomerBillingInfo billingInfo,
            string setupIntent)
        {
            this.BillingInfo = billingInfo ?? throw new global::System.ArgumentNullException(nameof(billingInfo));
            this.SetupIntent = setupIntent ?? throw new global::System.ArgumentNullException(nameof(setupIntent));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentInformation" /> class.
        /// </summary>
        public StripePaymentInformation()
        {
        }
    }
}