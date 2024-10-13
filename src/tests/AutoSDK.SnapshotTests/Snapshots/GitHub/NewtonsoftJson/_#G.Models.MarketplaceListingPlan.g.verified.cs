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

    }
}