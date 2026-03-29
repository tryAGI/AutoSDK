//HintName: G.Models.PricingTierCondition.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Condition for matching a pricing tier based on usage details. Used to implement tiered pricing models where costs vary based on usage thresholds.<br/>
    /// How it works:<br/>
    /// 1. The regex pattern matches against usage detail keys (e.g., "input_tokens", "input_cached")<br/>
    /// 2. Values of all matching keys are summed together<br/>
    /// 3. The sum is compared against the threshold value using the specified operator<br/>
    /// 4. All conditions in a tier must be met (AND logic) for the tier to match<br/>
    /// Common use cases:<br/>
    /// - Threshold-based pricing: Match when accumulated usage exceeds a certain amount<br/>
    /// - Usage-type-specific pricing: Different rates for cached vs non-cached tokens, or input vs output<br/>
    /// - Volume-based pricing: Different rates based on total request or token count
    /// </summary>
    public sealed partial class PricingTierCondition
    {
        /// <summary>
        /// Regex pattern to match against usage detail keys. All matching keys' values are summed for threshold comparison.<br/>
        /// Examples:<br/>
        /// - "^input" matches "input", "input_tokens", "input_cached", etc.<br/>
        /// - "^(input|prompt)" matches both "input_tokens" and "prompt_tokens"<br/>
        /// - "_cache$" matches "input_cache", "output_cache", etc.<br/>
        /// The pattern is case-insensitive by default. If no keys match, the sum is treated as zero.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("usageDetailPattern", Required = global::Newtonsoft.Json.Required.Always)]
        public string UsageDetailPattern { get; set; } = default!;

        /// <summary>
        /// Comparison operators for pricing tier conditions
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("operator", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.PricingTierOperator Operator { get; set; } = default!;

        /// <summary>
        /// Threshold value for comparison. For token-based pricing, this is typically the token count threshold (e.g., 200000 for a 200K token threshold).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("value", Required = global::Newtonsoft.Json.Required.Always)]
        public double Value { get; set; } = default!;

        /// <summary>
        /// Whether the regex pattern matching is case-sensitive. Default is false (case-insensitive matching).
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("caseSensitive", Required = global::Newtonsoft.Json.Required.Always)]
        public bool CaseSensitive { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierCondition" /> class.
        /// </summary>
        /// <param name="usageDetailPattern">
        /// Regex pattern to match against usage detail keys. All matching keys' values are summed for threshold comparison.<br/>
        /// Examples:<br/>
        /// - "^input" matches "input", "input_tokens", "input_cached", etc.<br/>
        /// - "^(input|prompt)" matches both "input_tokens" and "prompt_tokens"<br/>
        /// - "_cache$" matches "input_cache", "output_cache", etc.<br/>
        /// The pattern is case-insensitive by default. If no keys match, the sum is treated as zero.
        /// </param>
        /// <param name="operator">
        /// Comparison operators for pricing tier conditions
        /// </param>
        /// <param name="value">
        /// Threshold value for comparison. For token-based pricing, this is typically the token count threshold (e.g., 200000 for a 200K token threshold).
        /// </param>
        /// <param name="caseSensitive">
        /// Whether the regex pattern matching is case-sensitive. Default is false (case-insensitive matching).
        /// </param>
        public PricingTierCondition(
            string usageDetailPattern,
            global::G.PricingTierOperator @operator,
            double value,
            bool caseSensitive)
        {
            this.UsageDetailPattern = usageDetailPattern ?? throw new global::System.ArgumentNullException(nameof(usageDetailPattern));
            this.Operator = @operator;
            this.Value = value;
            this.CaseSensitive = caseSensitive;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierCondition" /> class.
        /// </summary>
        public PricingTierCondition()
        {
        }
    }
}