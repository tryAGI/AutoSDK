//HintName: G.Models.InvoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Example: {"amount_due_cents":1000,"discounts":[{"discount_percent_off":20.0}],"next_payment_attempt_unix":1738356858,"payment_intent_status":"processing","payment_intent_statusses":["processing","succeeded"],"subtotal_cents":900,"tax_cents":100}
    /// </summary>
    public sealed partial class InvoiceResponseModel
    {
        /// <summary>
        /// The amount due in cents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("amount_due_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int AmountDueCents { get; set; } = default!;

        /// <summary>
        /// The subtotal amount in cents before tax (exclusive of tax and discounts).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtotal_cents")]
        public int? SubtotalCents { get; set; }

        /// <summary>
        /// The tax amount in cents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("tax_cents")]
        public int? TaxCents { get; set; }

        /// <summary>
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discount_percent_off")]
        public double? DiscountPercentOff { get; set; }

        /// <summary>
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20 cents off.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discount_amount_off")]
        public double? DiscountAmountOff { get; set; }

        /// <summary>
        /// The discounts applied to the invoice.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discounts", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.DiscountResponseModel> Discounts { get; set; } = default!;

        /// <summary>
        /// The Unix timestamp of the next payment attempt. -1 when there is no next payment attempt.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_payment_attempt_unix", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTimeOffset NextPaymentAttemptUnix { get; set; } = default!;

        /// <summary>
        /// Deprecated. Use [payment_intent_statusses] instead. The status of this invoice's first payment intent. None when there is no payment intent.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payment_intent_status")]
        public global::G.InvoiceResponseModelPaymentIntentStatus2? PaymentIntentStatus { get; set; }

        /// <summary>
        /// The statuses of this invoice's payment intents. Empty list when there are no payment intents.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payment_intent_statusses", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.InvoiceResponseModelPaymentIntentStatusse> PaymentIntentStatusses { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponseModel" /> class.
        /// </summary>
        /// <param name="amountDueCents">
        /// The amount due in cents.
        /// </param>
        /// <param name="discounts">
        /// The discounts applied to the invoice.
        /// </param>
        /// <param name="nextPaymentAttemptUnix">
        /// The Unix timestamp of the next payment attempt. -1 when there is no next payment attempt.
        /// </param>
        /// <param name="paymentIntentStatusses">
        /// The statuses of this invoice's payment intents. Empty list when there are no payment intents.
        /// </param>
        /// <param name="subtotalCents">
        /// The subtotal amount in cents before tax (exclusive of tax and discounts).
        /// </param>
        /// <param name="taxCents">
        /// The tax amount in cents.
        /// </param>
        /// <param name="discountPercentOff">
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </param>
        /// <param name="discountAmountOff">
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20 cents off.
        /// </param>
        /// <param name="paymentIntentStatus">
        /// Deprecated. Use [payment_intent_statusses] instead. The status of this invoice's first payment intent. None when there is no payment intent.
        /// </param>
        public InvoiceResponseModel(
            int amountDueCents,
            global::System.Collections.Generic.IList<global::G.DiscountResponseModel> discounts,
            global::System.DateTimeOffset nextPaymentAttemptUnix,
            global::System.Collections.Generic.IList<global::G.InvoiceResponseModelPaymentIntentStatusse> paymentIntentStatusses,
            int? subtotalCents,
            int? taxCents,
            double? discountPercentOff,
            double? discountAmountOff,
            global::G.InvoiceResponseModelPaymentIntentStatus2? paymentIntentStatus)
        {
            this.AmountDueCents = amountDueCents;
            this.SubtotalCents = subtotalCents;
            this.TaxCents = taxCents;
            this.DiscountPercentOff = discountPercentOff;
            this.DiscountAmountOff = discountAmountOff;
            this.Discounts = discounts ?? throw new global::System.ArgumentNullException(nameof(discounts));
            this.NextPaymentAttemptUnix = nextPaymentAttemptUnix;
            this.PaymentIntentStatus = paymentIntentStatus;
            this.PaymentIntentStatusses = paymentIntentStatusses ?? throw new global::System.ArgumentNullException(nameof(paymentIntentStatusses));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponseModel" /> class.
        /// </summary>
        public InvoiceResponseModel()
        {
        }
    }
}