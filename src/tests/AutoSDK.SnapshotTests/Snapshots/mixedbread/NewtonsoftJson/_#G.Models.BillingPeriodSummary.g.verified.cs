//HintName: G.Models.BillingPeriodSummary.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// High level billing summary for the currently active period.
    /// </summary>
    public sealed partial class BillingPeriodSummary
    {
        /// <summary>
        /// The billing period
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("period", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.Period Period { get; set; } = default!;

        /// <summary>
        /// The cost information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cost", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.CostInfo Cost { get; set; } = default!;

        /// <summary>
        /// The balance information
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("balance", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.BalanceInfo Balance { get; set; } = default!;

        /// <summary>
        /// The monthly usages information per metric
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usages", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, global::G.UsageInfo> Usages { get; set; } = default!;

        /// <summary>
        /// The date and time the summary was generated
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("generated_at", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.DateTime GeneratedAt { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriodSummary" /> class.
        /// </summary>
        /// <param name="period">
        /// The billing period
        /// </param>
        /// <param name="cost">
        /// The cost information
        /// </param>
        /// <param name="balance">
        /// The balance information
        /// </param>
        /// <param name="usages">
        /// The monthly usages information per metric
        /// </param>
        /// <param name="generatedAt">
        /// The date and time the summary was generated
        /// </param>
        public BillingPeriodSummary(
            global::G.Period period,
            global::G.CostInfo cost,
            global::G.BalanceInfo balance,
            global::System.Collections.Generic.Dictionary<string, global::G.UsageInfo> usages,
            global::System.DateTime generatedAt)
        {
            this.Period = period ?? throw new global::System.ArgumentNullException(nameof(period));
            this.Cost = cost ?? throw new global::System.ArgumentNullException(nameof(cost));
            this.Balance = balance ?? throw new global::System.ArgumentNullException(nameof(balance));
            this.Usages = usages ?? throw new global::System.ArgumentNullException(nameof(usages));
            this.GeneratedAt = generatedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPeriodSummary" /> class.
        /// </summary>
        public BillingPeriodSummary()
        {
        }
    }
}