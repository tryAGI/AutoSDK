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
        [global::System.Text.Json.Serialization.JsonPropertyName("total_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_credit_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double MonthlyCreditBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("purchased_credit_balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PurchasedCreditBalance { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_tier")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingTier { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRetrieveCurrentBalancesResponse" /> class.
        /// </summary>
        /// <param name="totalBalance"></param>
        /// <param name="monthlyCreditBalance"></param>
        /// <param name="purchasedCreditBalance"></param>
        /// <param name="billingTier"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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