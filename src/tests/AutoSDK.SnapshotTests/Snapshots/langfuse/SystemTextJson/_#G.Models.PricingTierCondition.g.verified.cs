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
        [global::System.Text.Json.Serialization.JsonPropertyName("usageDetailPattern")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UsageDetailPattern { get; set; }

        /// <summary>
        /// Comparison operators for pricing tier conditions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operator")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.PricingTierOperatorJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.PricingTierOperator Operator { get; set; }

        /// <summary>
        /// Threshold value for comparison. For token-based pricing, this is typically the token count threshold (e.g., 200000 for a 200K token threshold).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// Whether the regex pattern matching is case-sensitive. Default is false (case-insensitive matching).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caseSensitive")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool CaseSensitive { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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