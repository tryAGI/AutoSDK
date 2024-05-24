//HintName: G.Models.UserMarketplacePurchase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// User Marketplace Purchase
    /// </summary>
    public sealed partial class UserMarketplacePurchase
    {
        /// <summary>
        /// <br/>Example: monthly
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("billing_cycle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BillingCycle { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_billing_date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int? UnitCount { get; set; }

        /// <summary>
        /// <br/>Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("on_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool OnFreeTrial { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("free_trial_ends_on")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? FreeTrialEndsOn { get; set; }

        /// <summary>
        /// <br/>Example: 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("account")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required MarketplaceAccount Account { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required MarketplaceListingPlan Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}