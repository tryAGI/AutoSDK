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
        [global::Newtonsoft.Json.JsonProperty("period", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Period Period { get; set; } = default!;

        /// <summary>
        /// The net usage cost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("net_usage_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public string NetUsageCost { get; set; } = default!;

        /// <summary>
        /// The gross usage cost
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("gross_usage_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public string GrossUsageCost { get; set; } = default!;

        /// <summary>
        /// The balance applied
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance_applied", Required = global::Newtonsoft.Json.Required.Always)]
        public string BalanceApplied { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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