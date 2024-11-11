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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MarketplaceListingPlanPriceModelJsonConverter))]
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
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
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::G.MarketplaceListingPlan? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::G.MarketplaceListingPlan),
                jsonSerializerContext) as global::G.MarketplaceListingPlan;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::G.MarketplaceListingPlan>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::G.MarketplaceListingPlan?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::G.MarketplaceListingPlan),
                jsonSerializerContext).ConfigureAwait(false)) as global::G.MarketplaceListingPlan;
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
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::G.MarketplaceListingPlan?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}