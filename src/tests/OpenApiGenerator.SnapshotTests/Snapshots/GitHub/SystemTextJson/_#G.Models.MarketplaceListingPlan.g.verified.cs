//HintName: G.Models.MarketplaceListingPlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Marketplace Listing Plan
    /// </summary>
    public sealed partial class MarketplaceListingPlan
    {
        /// <summary>
        /// Example: https://api.github.com/marketplace_listing/plans/1313
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/marketplace_listing/plans/1313/accounts
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountsUrl { get; set; }

        /// <summary>
        /// Example: 1313
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// Example: Pro
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: A professional-grade CI solution
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Example: 1099
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyPriceInCents { get; set; }

        /// <summary>
        /// Example: 11870
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yearly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int YearlyPriceInCents { get; set; }

        /// <summary>
        /// Example: FLAT_RATE
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenApiGenerator.JsonConverters.MarketplaceListingPlanPriceModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MarketplaceListingPlanPriceModel PriceModel { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? UnitName { get; set; }

        /// <summary>
        /// Example: published
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Example: [Up to 25 private repositories, 11 concurrent builds]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bullets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}