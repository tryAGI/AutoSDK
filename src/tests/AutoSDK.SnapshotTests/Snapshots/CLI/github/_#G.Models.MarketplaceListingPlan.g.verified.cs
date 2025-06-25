﻿//HintName: G.Models.MarketplaceListingPlan.g.cs

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
        /// <example>https://api.github.com/marketplace_listing/plans/1313</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// Example: https://api.github.com/marketplace_listing/plans/1313/accounts
        /// </summary>
        /// <example>https://api.github.com/marketplace_listing/plans/1313/accounts</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("accounts_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string AccountsUrl { get; set; }

        /// <summary>
        /// Example: 1313
        /// </summary>
        /// <example>1313</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Id { get; set; }

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Number { get; set; }

        /// <summary>
        /// Example: Pro
        /// </summary>
        /// <example>Pro</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Example: A professional-grade CI solution
        /// </summary>
        /// <example>A professional-grade CI solution</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Description { get; set; }

        /// <summary>
        /// Example: 1099
        /// </summary>
        /// <example>1099</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int MonthlyPriceInCents { get; set; }

        /// <summary>
        /// Example: 11870
        /// </summary>
        /// <example>11870</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("yearly_price_in_cents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int YearlyPriceInCents { get; set; }

        /// <summary>
        /// Example: FLAT_RATE
        /// </summary>
        /// <example>FLAT_RATE</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("price_model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MarketplaceListingPlanPriceModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.MarketplaceListingPlanPriceModel PriceModel { get; set; }

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
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
        /// <example>published</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Example: [Up to 25 private repositories, 11 concurrent builds]
        /// </summary>
        /// <example>[Up to 25 private repositories, 11 concurrent builds]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("bullets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Bullets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceListingPlan" /> class.
        /// </summary>
        /// <param name="url">
        /// Example: https://api.github.com/marketplace_listing/plans/1313
        /// </param>
        /// <param name="accountsUrl">
        /// Example: https://api.github.com/marketplace_listing/plans/1313/accounts
        /// </param>
        /// <param name="id">
        /// Example: 1313
        /// </param>
        /// <param name="number">
        /// Example: 3
        /// </param>
        /// <param name="name">
        /// Example: Pro
        /// </param>
        /// <param name="description">
        /// Example: A professional-grade CI solution
        /// </param>
        /// <param name="monthlyPriceInCents">
        /// Example: 1099
        /// </param>
        /// <param name="yearlyPriceInCents">
        /// Example: 11870
        /// </param>
        /// <param name="priceModel">
        /// Example: FLAT_RATE
        /// </param>
        /// <param name="hasFreeTrial">
        /// Example: true
        /// </param>
        /// <param name="unitName"></param>
        /// <param name="state">
        /// Example: published
        /// </param>
        /// <param name="bullets">
        /// Example: [Up to 25 private repositories, 11 concurrent builds]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MarketplaceListingPlan(
            string url,
            string accountsUrl,
            int id,
            int number,
            string name,
            string description,
            int monthlyPriceInCents,
            int yearlyPriceInCents,
            global::G.MarketplaceListingPlanPriceModel priceModel,
            bool hasFreeTrial,
            string? unitName,
            string state,
            global::System.Collections.Generic.IList<string> bullets)
        {
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.AccountsUrl = accountsUrl ?? throw new global::System.ArgumentNullException(nameof(accountsUrl));
            this.Id = id;
            this.Number = number;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description ?? throw new global::System.ArgumentNullException(nameof(description));
            this.MonthlyPriceInCents = monthlyPriceInCents;
            this.YearlyPriceInCents = yearlyPriceInCents;
            this.PriceModel = priceModel;
            this.HasFreeTrial = hasFreeTrial;
            this.UnitName = unitName ?? throw new global::System.ArgumentNullException(nameof(unitName));
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.Bullets = bullets ?? throw new global::System.ArgumentNullException(nameof(bullets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplaceListingPlan" /> class.
        /// </summary>
        public MarketplaceListingPlan()
        {
        }
    }
}