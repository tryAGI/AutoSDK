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
        [global::Newtonsoft.Json.JsonProperty("billing_info", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.StripeCustomerBillingInfo BillingInfo { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("setup_intent", Required = global::Newtonsoft.Json.Required.Always)]
        public string SetupIntent { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StripePaymentInformation" /> class.
        /// </summary>
        /// <param name="billingInfo">
        /// Stripe customer billing information.
        /// </param>
        /// <param name="setupIntent"></param>
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