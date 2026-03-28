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
        [global::System.Text.Json.Serialization.JsonPropertyName("amount_due_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AmountDueCents { get; set; }

        /// <summary>
        /// The subtotal amount in cents before tax (exclusive of tax and discounts).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal_cents")]
        public int? SubtotalCents { get; set; }

        /// <summary>
        /// The tax amount in cents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tax_cents")]
        public int? TaxCents { get; set; }

        /// <summary>
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_percent_off")]
        public double? DiscountPercentOff { get; set; }

        /// <summary>
        /// Deprecated. Use [discounts] instead. The discount applied to the invoice. E.g. [20.0f] for 20 cents off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_amount_off")]
        public double? DiscountAmountOff { get; set; }

        /// <summary>
        /// The discounts applied to the invoice.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.DiscountResponseModel> Discounts { get; set; }

        /// <summary>
        /// The Unix timestamp of the next payment attempt. -1 when there is no next payment attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_payment_attempt_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset NextPaymentAttemptUnix { get; set; }

        /// <summary>
        /// Deprecated. Use [payment_intent_statusses] instead. The status of this invoice's first payment intent. None when there is no payment intent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_intent_status")]
        public global::G.InvoiceResponseModelPaymentIntentStatus2? PaymentIntentStatus { get; set; }

        /// <summary>
        /// The statuses of this invoice's payment intents. Empty list when there are no payment intents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_intent_statusses")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.InvoiceResponseModelPaymentIntentStatusse> PaymentIntentStatusses { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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