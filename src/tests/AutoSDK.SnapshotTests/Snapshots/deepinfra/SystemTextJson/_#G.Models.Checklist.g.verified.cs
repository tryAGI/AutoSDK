//HintName: G.Models.Checklist.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Checklist
    {
        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_address")]
        public bool? BillingAddress { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("payment_method")]
        public bool? PaymentMethod { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("overdue_invoices")]
        public double? OverdueInvoices { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_checked")]
        public int? LastChecked { get; set; }

        /// <summary>
        /// Negative value indicates funds ready-to-spend. Positive value indicates money owed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stripe_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double StripeBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double? Limit { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("suspend_reason")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.SuspendReason? SuspendReason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Checklist" /> class.
        /// </summary>
        /// <param name="email">
        /// Default Value: false
        /// </param>
        /// <param name="billingAddress">
        /// Default Value: false
        /// </param>
        /// <param name="paymentMethod">
        /// Default Value: false
        /// </param>
        /// <param name="suspended">
        /// Default Value: false
        /// </param>
        /// <param name="overdueInvoices">
        /// Default Value: 0F
        /// </param>
        /// <param name="lastChecked">
        /// Default Value: 0
        /// </param>
        /// <param name="stripeBalance">
        /// Negative value indicates funds ready-to-spend. Positive value indicates money owed
        /// </param>
        /// <param name="limit"></param>
        /// <param name="suspendReason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Checklist(
            double stripeBalance,
            double? limit,
            global::G.SuspendReason? suspendReason,
            bool? email,
            bool? billingAddress,
            bool? paymentMethod,
            bool? suspended,
            double? overdueInvoices,
            int? lastChecked)
        {
            this.StripeBalance = stripeBalance;
            this.Limit = limit ?? throw new global::System.ArgumentNullException(nameof(limit));
            this.SuspendReason = suspendReason ?? throw new global::System.ArgumentNullException(nameof(suspendReason));
            this.Email = email;
            this.BillingAddress = billingAddress;
            this.PaymentMethod = paymentMethod;
            this.Suspended = suspended;
            this.OverdueInvoices = overdueInvoices;
            this.LastChecked = lastChecked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Checklist" /> class.
        /// </summary>
        public Checklist()
        {
        }
    }
}