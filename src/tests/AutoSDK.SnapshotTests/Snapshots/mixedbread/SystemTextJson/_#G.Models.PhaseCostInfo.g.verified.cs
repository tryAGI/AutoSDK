//HintName: G.Models.PhaseCostInfo.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost information for a billing phase.
    /// </summary>
    public sealed partial class PhaseCostInfo
    {
        /// <summary>
        /// The period
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Period Period { get; set; }

        /// <summary>
        /// The net usage cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("net_usage_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string NetUsageCost { get; set; }

        /// <summary>
        /// The gross usage cost
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gross_usage_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string GrossUsageCost { get; set; }

        /// <summary>
        /// The balance applied
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance_applied")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BalanceApplied { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PhaseCostInfo" /> class.
        /// </summary>
        /// <param name="period">
        /// The period
        /// </param>
        /// <param name="netUsageCost">
        /// The net usage cost
        /// </param>
        /// <param name="grossUsageCost">
        /// The gross usage cost
        /// </param>
        /// <param name="balanceApplied">
        /// The balance applied
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PhaseCostInfo(
            global::G.Period period,
            string netUsageCost,
            string grossUsageCost,
            string balanceApplied)
        {
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.NetUsageCost = netUsageCost ?? throw new global::System.ArgumentNullException(nameof(netUsageCost));
            this.GrossUsageCost = grossUsageCost ?? throw new global::System.ArgumentNullException(nameof(grossUsageCost));
            this.BalanceApplied = balanceApplied ?? throw new global::System.ArgumentNullException(nameof(balanceApplied));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PhaseCostInfo" /> class.
        /// </summary>
        public PhaseCostInfo()
        {
        }
    }
}