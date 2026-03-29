//HintName: G.Models.PricingTier.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pricing tier definition with conditional pricing based on usage thresholds.<br/>
    /// Pricing tiers enable accurate cost tracking for LLM providers that charge different rates based on usage patterns.<br/>
    /// For example, some providers charge higher rates when context size exceeds certain thresholds.<br/>
    /// How tier matching works:<br/>
    /// 1. Tiers are evaluated in ascending priority order (priority 1 before priority 2, etc.)<br/>
    /// 2. The first tier where ALL conditions match is selected<br/>
    /// 3. If no conditional tiers match, the default tier is used as a fallback<br/>
    /// 4. The default tier has priority 0 and no conditions<br/>
    /// Why priorities matter:<br/>
    /// - Lower priority numbers are evaluated first, allowing you to define specific cases before general ones<br/>
    /// - Example: Priority 1 for "high usage" (&gt;200K tokens), Priority 2 for "medium usage" (&gt;100K tokens), Priority 0 for default<br/>
    /// - Without proper ordering, a less specific condition might match before a more specific one<br/>
    /// Every model must have exactly one default tier to ensure cost calculation always succeeds.
    /// </summary>
    public sealed partial class PricingTier
    {
        /// <summary>
        /// Unique identifier for the pricing tier
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the pricing tier for display and identification purposes.<br/>
        /// Examples: "Standard", "High Volume Tier", "Large Context", "Extended Context Tier"
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Whether this is the default tier. Every model must have exactly one default tier with priority 0 and no conditions.<br/>
        /// The default tier serves as a fallback when no conditional tiers match, ensuring cost calculation always succeeds.<br/>
        /// It typically represents the base pricing for standard usage patterns.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("isDefault", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsDefault { get; set; } = default!;

        /// <summary>
        /// Priority for tier matching evaluation. Lower numbers = higher priority (evaluated first).<br/>
        /// The default tier must always have priority 0. Conditional tiers should have priority 1, 2, 3, etc.<br/>
        /// Example ordering:<br/>
        /// - Priority 0: Default tier (no conditions, always matches as fallback)<br/>
        /// - Priority 1: High usage tier (e.g., &gt;200K tokens)<br/>
        /// - Priority 2: Medium usage tier (e.g., &gt;100K tokens)<br/>
        /// This ensures more specific conditions are checked before general ones.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("priority", Required = global::Newtonsoft.Json.Required.Always)]
        public int Priority { get; set; } = default!;

        /// <summary>
        /// Array of conditions that must ALL be met for this tier to match (AND logic).<br/>
        /// The default tier must have an empty conditions array. Conditional tiers should have one or more conditions<br/>
        /// that define when this tier's pricing applies.<br/>
        /// Multiple conditions enable complex matching scenarios (e.g., "high input tokens AND low output tokens").
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conditions", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.PricingTierCondition> Conditions { get; set; } = default!;

        /// <summary>
        /// Prices (USD) by usage type for this tier.<br/>
        /// Common usage types: "input", "output", "total", "request", "image"<br/>
        /// Prices are specified in USD per unit (e.g., per token, per request, per second).<br/>
        /// Example: {"input": 0.000003, "output": 0.000015} means $3 per million input tokens and $15 per million output tokens.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("prices", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.Dictionary<string, double> Prices { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTier" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier for the pricing tier
        /// </param>
        /// <param name="name">
        /// Name of the pricing tier for display and identification purposes.<br/>
        /// Examples: "Standard", "High Volume Tier", "Large Context", "Extended Context Tier"
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the default tier. Every model must have exactly one default tier with priority 0 and no conditions.<br/>
        /// The default tier serves as a fallback when no conditional tiers match, ensuring cost calculation always succeeds.<br/>
        /// It typically represents the base pricing for standard usage patterns.
        /// </param>
        /// <param name="priority">
        /// Priority for tier matching evaluation. Lower numbers = higher priority (evaluated first).<br/>
        /// The default tier must always have priority 0. Conditional tiers should have priority 1, 2, 3, etc.<br/>
        /// Example ordering:<br/>
        /// - Priority 0: Default tier (no conditions, always matches as fallback)<br/>
        /// - Priority 1: High usage tier (e.g., &gt;200K tokens)<br/>
        /// - Priority 2: Medium usage tier (e.g., &gt;100K tokens)<br/>
        /// This ensures more specific conditions are checked before general ones.
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that must ALL be met for this tier to match (AND logic).<br/>
        /// The default tier must have an empty conditions array. Conditional tiers should have one or more conditions<br/>
        /// that define when this tier's pricing applies.<br/>
        /// Multiple conditions enable complex matching scenarios (e.g., "high input tokens AND low output tokens").
        /// </param>
        /// <param name="prices">
        /// Prices (USD) by usage type for this tier.<br/>
        /// Common usage types: "input", "output", "total", "request", "image"<br/>
        /// Prices are specified in USD per unit (e.g., per token, per request, per second).<br/>
        /// Example: {"input": 0.000003, "output": 0.000015} means $3 per million input tokens and $15 per million output tokens.
        /// </param>
        public PricingTier(
            string id,
            string name,
            bool isDefault,
            int priority,
            global::System.Collections.Generic.IList<global::G.PricingTierCondition> conditions,
            global::System.Collections.Generic.Dictionary<string, double> prices)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDefault = isDefault;
            this.Priority = priority;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTier" /> class.
        /// </summary>
        public PricingTier()
        {
        }
    }
}