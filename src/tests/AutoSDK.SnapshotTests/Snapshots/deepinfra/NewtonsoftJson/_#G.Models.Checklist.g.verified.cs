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
        [global::Newtonsoft.Json.JsonProperty("email")]
        public bool? Email { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_address")]
        public bool? BillingAddress { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("payment_method")]
        public bool? PaymentMethod { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspended")]
        public bool? Suspended { get; set; }

        /// <summary>
        /// Default Value: 0F
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("overdue_invoices")]
        public double? OverdueInvoices { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("last_checked")]
        public int? LastChecked { get; set; }

        /// <summary>
        /// Negative value indicates funds ready-to-spend. Positive value indicates money owed
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stripe_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double StripeBalance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("limit", Required = global::Newtonsoft.Json.Required.Always)]
        public double? Limit { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("suspend_reason", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.SuspendReason? SuspendReason { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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