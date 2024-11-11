//HintName: G.Models.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("account", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchaseAccount Account { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("billing_cycle", Required = global::Newtonsoft.Json.Required.Always)]
        public string BillingCycle { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("free_trial_ends_on", Required = global::Newtonsoft.Json.Required.Always)]
        public string? FreeTrialEndsOn { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("next_billing_date")]
        public string? NextBillingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("on_free_trial", Required = global::Newtonsoft.Json.Required.Always)]
        public bool? OnFreeTrial { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("plan", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan Plan { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_count", Required = global::Newtonsoft.Json.Required.Always)]
        public int UnitCount { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase" /> class.
        /// </summary>
        /// <param name="account"></param>
        /// <param name="billingCycle"></param>
        /// <param name="freeTrialEndsOn"></param>
        /// <param name="nextBillingDate"></param>
        /// <param name="onFreeTrial"></param>
        /// <param name="plan"></param>
        /// <param name="unitCount"></param>
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase(
            global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchaseAccount account,
            string billingCycle,
            string? freeTrialEndsOn,
            bool? onFreeTrial,
            global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchasePlan plan,
            int unitCount,
            string? nextBillingDate)
        {
            this.Account = account ?? throw new global::System.ArgumentNullException(nameof(account));
            this.BillingCycle = billingCycle ?? throw new global::System.ArgumentNullException(nameof(billingCycle));
            this.FreeTrialEndsOn = freeTrialEndsOn ?? throw new global::System.ArgumentNullException(nameof(freeTrialEndsOn));
            this.OnFreeTrial = onFreeTrial;
            this.Plan = plan ?? throw new global::System.ArgumentNullException(nameof(plan));
            this.UnitCount = unitCount;
            this.NextBillingDate = nextBillingDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase" /> class.
        /// </summary>
        public WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase()
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
        public static global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase? FromJson(
            string json,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase>(
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
        public static global::System.Threading.Tasks.ValueTask<global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase?> FromJsonStreamAsync(
            global::System.IO.Stream jsonStream,
            global::Newtonsoft.Json.JsonSerializerSettings? jsonSerializerOptions = null)
        {
            using var streamReader = new global::System.IO.StreamReader(jsonStream);
            using var jsonReader = new global::Newtonsoft.Json.JsonTextReader(streamReader);
            var serializer = global::Newtonsoft.Json.JsonSerializer.Create(jsonSerializerOptions);
            return new global::System.Threading.Tasks.ValueTask<global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase?>(serializer.Deserialize<global::G.WebhookMarketplacePurchaseChangedPreviousMarketplacePurchase>(jsonReader));
        }

    }
}