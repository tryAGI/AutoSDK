//HintName: G.Models.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bullets { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_free_trial")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyPriceInCents { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel PriceModel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? UnitName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("yearly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int YearlyPriceInCents { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan" /> class.
        /// </summary>
        /// <param name="bullets"></param>
        /// <param name="description"></param>
        /// <param name="hasFreeTrial"></param>
        /// <param name="id"></param>
        /// <param name="monthlyPriceInCents"></param>
        /// <param name="name"></param>
        /// <param name="priceModel"></param>
        /// <param name="unitName"></param>
        /// <param name="yearlyPriceInCents"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan(
            global::System.Collections.Generic.IList<string> bullets,
            string description,
            bool hasFreeTrial,
            int id,
            int monthlyPriceInCents,
            string name,
            global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlanPriceModel priceModel,
            string? unitName,
            int yearlyPriceInCents)
        {
            this.Bullets = bullets ?? throw new global::System.ArgumentNullException(nameof(bullets));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.HasFreeTrial = hasFreeTrial;
            this.Id = id;
            this.MonthlyPriceInCents = monthlyPriceInCents;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PriceModel = priceModel;
            this.UnitName = unitName ?? throw new global::System.ArgumentNullException(nameof(unitName));
            this.YearlyPriceInCents = yearlyPriceInCents;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan" /> class.
        /// </summary>
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan()
        {
        }
    }
}