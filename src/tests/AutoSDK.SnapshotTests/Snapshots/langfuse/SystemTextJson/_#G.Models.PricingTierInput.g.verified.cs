//HintName: G.Models.PricingTierInput.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Input schema for creating a pricing tier. The tier ID will be automatically generated server-side.<br/>
    /// When creating a model with pricing tiers:<br/>
    /// - Exactly one tier must have isDefault=true (the fallback tier)<br/>
    /// - The default tier must have priority=0 and conditions=[]<br/>
    /// - All tier names and priorities must be unique within the model<br/>
    /// - Each tier must define at least one price<br/>
    /// See PricingTier for detailed information about how tiers work and why they're useful.
    /// </summary>
    public sealed partial class PricingTierInput
    {
        /// <summary>
        /// Name of the pricing tier for display and identification purposes.<br/>
        /// Must be unique within the model. Common patterns: "Standard", "High Volume Tier", "Extended Context"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether this is the default tier. Exactly one tier per model must be marked as default.<br/>
        /// Requirements for default tier:<br/>
        /// - Must have isDefault=true<br/>
        /// - Must have priority=0<br/>
        /// - Must have empty conditions array (conditions=[])<br/>
        /// The default tier acts as a fallback when no conditional tiers match.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isDefault")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDefault { get; set; }

        /// <summary>
        /// Priority for tier matching evaluation. Lower numbers = higher priority (evaluated first).<br/>
        /// Must be unique within the model. The default tier must have priority=0.<br/>
        /// Conditional tiers should use priority 1, 2, 3, etc. based on their specificity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("priority")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Priority { get; set; }

        /// <summary>
        /// Array of conditions that must ALL be met for this tier to match (AND logic).<br/>
        /// The default tier must have an empty array (conditions=[]).<br/>
        /// Conditional tiers should define one or more conditions that specify when this tier's pricing applies.<br/>
        /// Each condition specifies a regex pattern, operator, and threshold value for matching against usage details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conditions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::G.PricingTierCondition> Conditions { get; set; }

        /// <summary>
        /// Prices (USD) by usage type for this tier. At least one price must be defined.<br/>
        /// Common usage types: "input", "output", "total", "request", "image"<br/>
        /// Prices are in USD per unit (e.g., per token).<br/>
        /// Example: {"input": 0.000003, "output": 0.000015} represents $3 per million input tokens and $15 per million output tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Prices { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierInput" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the pricing tier for display and identification purposes.<br/>
        /// Must be unique within the model. Common patterns: "Standard", "High Volume Tier", "Extended Context"
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the default tier. Exactly one tier per model must be marked as default.<br/>
        /// Requirements for default tier:<br/>
        /// - Must have isDefault=true<br/>
        /// - Must have priority=0<br/>
        /// - Must have empty conditions array (conditions=[])<br/>
        /// The default tier acts as a fallback when no conditional tiers match.
        /// </param>
        /// <param name="priority">
        /// Priority for tier matching evaluation. Lower numbers = higher priority (evaluated first).<br/>
        /// Must be unique within the model. The default tier must have priority=0.<br/>
        /// Conditional tiers should use priority 1, 2, 3, etc. based on their specificity.
        /// </param>
        /// <param name="conditions">
        /// Array of conditions that must ALL be met for this tier to match (AND logic).<br/>
        /// The default tier must have an empty array (conditions=[]).<br/>
        /// Conditional tiers should define one or more conditions that specify when this tier's pricing applies.<br/>
        /// Each condition specifies a regex pattern, operator, and threshold value for matching against usage details.
        /// </param>
        /// <param name="prices">
        /// Prices (USD) by usage type for this tier. At least one price must be defined.<br/>
        /// Common usage types: "input", "output", "total", "request", "image"<br/>
        /// Prices are in USD per unit (e.g., per token).<br/>
        /// Example: {"input": 0.000003, "output": 0.000015} represents $3 per million input tokens and $15 per million output tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingTierInput(
            string name,
            bool isDefault,
            int priority,
            global::System.Collections.Generic.IList<global::G.PricingTierCondition> conditions,
            global::System.Collections.Generic.Dictionary<string, double> prices)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IsDefault = isDefault;
            this.Priority = priority;
            this.Conditions = conditions ?? throw new global::System.ArgumentNullException(nameof(conditions));
            this.Prices = prices ?? throw new global::System.ArgumentNullException(nameof(prices));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingTierInput" /> class.
        /// </summary>
        public PricingTierInput()
        {
        }
    }
}