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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/marketplace_listing/plans/1313/accounts
        /// </summary>
        /// <example>https://api.github.com/marketplace_listing/plans/1313/accounts</example>
        [global::Newtonsoft.Json.JsonProperty("accounts_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccountsUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1313
        /// </summary>
        /// <example>1313</example>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Example: Pro
        /// </summary>
        /// <example>Pro</example>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: A professional-grade CI solution
        /// </summary>
        /// <example>A professional-grade CI solution</example>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Example: 1099
        /// </summary>
        /// <example>1099</example>
        [global::Newtonsoft.Json.JsonProperty("monthly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int MonthlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// Example: 11870
        /// </summary>
        /// <example>11870</example>
        [global::Newtonsoft.Json.JsonProperty("yearly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int YearlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// Example: FLAT_RATE
        /// </summary>
        /// <example>FLAT_RATE</example>
        [global::Newtonsoft.Json.JsonProperty("price_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MarketplaceListingPlanPriceModel PriceModel { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("has_free_trial", Required = global::Newtonsoft.Json.Required.Always)]
        public bool HasFreeTrial { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_name", Required = global::Newtonsoft.Json.Required.Always)]
        public string? UnitName { get; set; } = default!;

        /// <summary>
        /// Example: published
        /// </summary>
        /// <example>published</example>
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: [Up to 25 private repositories, 11 concurrent builds]
        /// </summary>
        /// <example>[Up to 25 private repositories, 11 concurrent builds]</example>
        [global::Newtonsoft.Json.JsonProperty("bullets", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<string> Bullets { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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