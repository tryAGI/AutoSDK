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
        [global::System.Text.Json.Serialization.JsonPropertyName("period")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.Period Period { get; set; }

        /// <summary>
        /// The cost information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.CostInfo Cost { get; set; }

        /// <summary>
        /// The balance information
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("balance")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.BalanceInfo Balance { get; set; }

        /// <summary>
        /// The monthly usages information per metric
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.UsageInfo> Usages { get; set; }

        /// <summary>
        /// The date and time the summary was generated
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("generated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime GeneratedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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