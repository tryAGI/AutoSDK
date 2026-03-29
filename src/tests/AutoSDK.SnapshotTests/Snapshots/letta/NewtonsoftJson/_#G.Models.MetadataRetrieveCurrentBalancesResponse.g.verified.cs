//HintName: G.Models.MetadataRetrieveCurrentBalancesResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataRetrieveCurrentBalancesResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalBalance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthly_credit_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double MonthlyCreditBalance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("purchased_credit_balance", Required = global::Newtonsoft.Json.Required.Always)]
        public double PurchasedCreditBalance { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_tier", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillingTier { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRetrieveCurrentBalancesResponse" /> class.
        /// </summary>
        /// <param name="totalBalance"></param>
        /// <param name="monthlyCreditBalance"></param>
        /// <param name="purchasedCreditBalance"></param>
        /// <param name="billingTier"></param>
        public MetadataRetrieveCurrentBalancesResponse(
            double totalBalance,
            double monthlyCreditBalance,
            double purchasedCreditBalance,
            string billingTier)
        {
            this.TotalBalance = totalBalance;
            this.MonthlyCreditBalance = monthlyCreditBalance;
            this.PurchasedCreditBalance = purchasedCreditBalance;
            this.BillingTier = billingTier ?? throw new global::System.ArgumentNullException(nameof(billingTier));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRetrieveCurrentBalancesResponse" /> class.
        /// </summary>
        public MetadataRetrieveCurrentBalancesResponse()
        {
        }
    }
}