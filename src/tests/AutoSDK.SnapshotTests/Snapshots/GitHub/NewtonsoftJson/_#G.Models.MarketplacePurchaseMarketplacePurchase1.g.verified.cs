//HintName: G.Models.MarketplacePurchaseMarketplacePurchase1.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MarketplacePurchaseMarketplacePurchase1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_cycle")]
        public string? BillingCycle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_billing_date")]
        public string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_installed")]
        public bool? IsInstalled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count")]
        public int? UnitCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_free_trial")]
        public bool? OnFreeTrial { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_trial_ends_on")]
        public string? FreeTrialEndsOn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        /// <summary>
        /// Marketplace Listing Plan
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan")]
        public global::G.MarketplaceListingPlan? Plan { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePurchase1" /> class.
        /// </summary>
        /// <param name="billingCycle"></param>
        /// <param name="nextBillingDate"></param>
        /// <param name="isInstalled"></param>
        /// <param name="unitCount"></param>
        /// <param name="onFreeTrial"></param>
        /// <param name="freeTrialEndsOn"></param>
        /// <param name="updatedAt"></param>
        /// <param name="plan">
        /// Marketplace Listing Plan
        /// </param>
        public MarketplacePurchaseMarketplacePurchase1(
            string? billingCycle,
            string? nextBillingDate,
            bool? isInstalled,
            int? unitCount,
            bool? onFreeTrial,
            string? freeTrialEndsOn,
            string? updatedAt,
            global::G.MarketplaceListingPlan? plan)
        {
            this.BillingCycle = billingCycle;
            this.NextBillingDate = nextBillingDate;
            this.IsInstalled = isInstalled;
            this.UnitCount = unitCount;
            this.OnFreeTrial = onFreeTrial;
            this.FreeTrialEndsOn = freeTrialEndsOn;
            this.UpdatedAt = updatedAt;
            this.Plan = plan;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MarketplacePurchaseMarketplacePurchase1" /> class.
        /// </summary>
        public MarketplacePurchaseMarketplacePurchase1()
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
        public static global::G.MarketplacePurchaseMarketplacePurchase1? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.MarketplacePurchaseMarketplacePurchase1>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.MarketplacePurchaseMarketplacePurchase1?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.MarketplacePurchaseMarketplacePurchase1?>(serializer.Deserialize<global::G.MarketplacePurchaseMarketplacePurchase1>(jsonReader));
        }

    }
}