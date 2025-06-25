//HintName: G.Models.InvoiceResponseModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
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
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_percent_off")]
        public double? DiscountPercentOff { get; set; }

        /// <summary>
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discount_amount_off")]
        public double? DiscountAmountOff { get; set; }

        /// <summary>
        /// The Unix timestamp of the next payment attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_payment_attempt_unix")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset NextPaymentAttemptUnix { get; set; }

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
        /// <param name="discountPercentOff">
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </param>
        /// <param name="discountAmountOff">
        /// The discount applied to the invoice. E.g. [20.0f] for 20% off.
        /// </param>
        /// <param name="nextPaymentAttemptUnix">
        /// The Unix timestamp of the next payment attempt.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InvoiceResponseModel(
            int amountDueCents,
            global::System.DateTimeOffset nextPaymentAttemptUnix,
            double? discountPercentOff,
            double? discountAmountOff)
        {
            this.AmountDueCents = amountDueCents;
            this.NextPaymentAttemptUnix = nextPaymentAttemptUnix;
            this.DiscountPercentOff = discountPercentOff;
            this.DiscountAmountOff = discountAmountOff;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceResponseModel" /> class.
        /// </summary>
        public InvoiceResponseModel()
        {
        }
    }
}