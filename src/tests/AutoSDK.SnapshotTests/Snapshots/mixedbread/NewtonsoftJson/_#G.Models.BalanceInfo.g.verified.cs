//HintName: G.Models.BalanceInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Information about an organization's credit balance.
    /// </summary>
    public sealed partial class BalanceInfo
    {
        /// <summary>
        /// The current balance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("current_balance")]
        public double? CurrentBalance { get; set; }

        /// <summary>
        /// The next effective balance
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_effective_balance")]
        public double? NextEffectiveBalance { get; set; }

        /// <summary>
        /// The next effective date
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_effective_date")]
        public global::System.DateTime? NextEffectiveDate { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceInfo" /> class.
        /// </summary>
        /// <param name="currentBalance">
        /// The current balance
        /// </param>
        /// <param name="nextEffectiveBalance">
        /// The next effective balance
        /// </param>
        /// <param name="nextEffectiveDate">
        /// The next effective date
        /// </param>
        public BalanceInfo(
            double? currentBalance,
            double? nextEffectiveBalance,
            global::System.DateTime? nextEffectiveDate)
        {
            this.CurrentBalance = currentBalance;
            this.NextEffectiveBalance = nextEffectiveBalance;
            this.NextEffectiveDate = nextEffectiveDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BalanceInfo" /> class.
        /// </summary>
        public BalanceInfo()
        {
        }
    }
}