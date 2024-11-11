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
        [global::Newtonsoft.Json.JsonProperty("url", Required = global::Newtonsoft.Json.Required.Always)]
        public string Url { get; set; } = default!;

        /// <summary>
        /// Example: https://api.github.com/marketplace_listing/plans/1313/accounts
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("accounts_url", Required = global::Newtonsoft.Json.Required.Always)]
        public string AccountsUrl { get; set; } = default!;

        /// <summary>
        /// Example: 1313
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("id", Required = global::Newtonsoft.Json.Required.Always)]
        public int Id { get; set; } = default!;

        /// <summary>
        /// Example: 3
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("number", Required = global::Newtonsoft.Json.Required.Always)]
        public int Number { get; set; } = default!;

        /// <summary>
        /// Example: Pro
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("name", Required = global::Newtonsoft.Json.Required.Always)]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Example: A professional-grade CI solution
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("description", Required = global::Newtonsoft.Json.Required.Always)]
        public string Description { get; set; } = default!;

        /// <summary>
        /// Example: 1099
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("monthly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int MonthlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// Example: 11870
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("yearly_price_in_cents", Required = global::Newtonsoft.Json.Required.Always)]
        public int YearlyPriceInCents { get; set; } = default!;

        /// <summary>
        /// Example: FLAT_RATE
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("price_model", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.MarketplaceListingPlanPriceModel PriceModel { get; set; } = default!;

        /// <summary>
        /// Example: true
        /// </summary>
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
        [global::Newtonsoft.Json.JsonProperty("state", Required = global::Newtonsoft.Json.Required.Always)]
        public string State { get; set; } = default!;

        /// <summary>
        /// Example: [Up to 25 private repositories, 11 concurrent builds]
        /// </summary>
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


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::G.MarketplaceListingPlan? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MarketplaceListingPlan>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER     
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::G.MarketplaceListingPlan?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MarketplaceListingPlan?>(serializer.Deserialize<global::G.MarketplaceListingPlan>(jsonReader));
        }

    }
}