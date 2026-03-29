//HintName: G.Models.GetConcurrencyResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GetConcurrencyResponse
    {
        /// <summary>
        /// The current concurrency (amount of ongoing calls) of the org.<br/>
        /// Example: 10
        /// </summary>
        /// <example>10</example>
        [global::Newtonsoft.Json.JsonProperty("current_concurrency")]
        public int? CurrentConcurrency { get; set; }

        /// <summary>
        /// The total concurrency limit (at max how many ongoing calls one can make) of the org. This should be the sum of `base_concurrency` and `purchased_concurrency`.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("concurrency_limit")]
        public int? ConcurrencyLimit { get; set; }

        /// <summary>
        /// The free concurrency limit of the org.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("base_concurrency")]
        public int? BaseConcurrency { get; set; }

        /// <summary>
        /// The amount of concurrency that the org has already purchased.<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::Newtonsoft.Json.JsonProperty("purchased_concurrency")]
        public int? PurchasedConcurrency { get; set; }

        /// <summary>
        /// The maximum amount of concurrency that the org can purchase.<br/>
        /// Example: 100
        /// </summary>
        /// <example>100</example>
        [global::Newtonsoft.Json.JsonProperty("concurrency_purchase_limit")]
        public int? ConcurrencyPurchaseLimit { get; set; }

        /// <summary>
        /// The remaining amount of concurrency that the org can purchase. This is the difference between `concurrency_purchase_limit` and `purchased_concurrency`.<br/>
        /// Example: 20
        /// </summary>
        /// <example>20</example>
        [global::Newtonsoft.Json.JsonProperty("remaining_purchase_limit")]
        public int? RemainingPurchaseLimit { get; set; }

        /// <summary>
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit with a surcharge.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::Newtonsoft.Json.JsonProperty("concurrency_burst_enabled")]
        public bool? ConcurrencyBurstEnabled { get; set; }

        /// <summary>
        /// The maximum concurrency limit when burst mode is enabled. This is calculated as min(3x normal limit, normal limit + 300). Returns 0 if burst mode is disabled.<br/>
        /// Included only in responses<br/>
        /// Example: 60
        /// </summary>
        /// <example>60</example>
        [global::Newtonsoft.Json.JsonProperty("concurrency_burst_limit")]
        public int? ConcurrencyBurstLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrencyResponse" /> class.
        /// </summary>
        /// <param name="currentConcurrency">
        /// The current concurrency (amount of ongoing calls) of the org.<br/>
        /// Example: 10
        /// </param>
        /// <param name="concurrencyLimit">
        /// The total concurrency limit (at max how many ongoing calls one can make) of the org. This should be the sum of `base_concurrency` and `purchased_concurrency`.<br/>
        /// Example: 100
        /// </param>
        /// <param name="baseConcurrency">
        /// The free concurrency limit of the org.<br/>
        /// Example: 20
        /// </param>
        /// <param name="purchasedConcurrency">
        /// The amount of concurrency that the org has already purchased.<br/>
        /// Example: 80
        /// </param>
        /// <param name="concurrencyPurchaseLimit">
        /// The maximum amount of concurrency that the org can purchase.<br/>
        /// Example: 100
        /// </param>
        /// <param name="remainingPurchaseLimit">
        /// The remaining amount of concurrency that the org can purchase. This is the difference between `concurrency_purchase_limit` and `purchased_concurrency`.<br/>
        /// Example: 20
        /// </param>
        /// <param name="concurrencyBurstEnabled">
        /// Whether burst concurrency mode is enabled. When enabled, allows the org to exceed their normal concurrency limit with a surcharge.<br/>
        /// Example: true
        /// </param>
        /// <param name="concurrencyBurstLimit">
        /// The maximum concurrency limit when burst mode is enabled. This is calculated as min(3x normal limit, normal limit + 300). Returns 0 if burst mode is disabled.<br/>
        /// Included only in responses<br/>
        /// Example: 60
        /// </param>
        public GetConcurrencyResponse(
            int? currentConcurrency,
            int? concurrencyLimit,
            int? baseConcurrency,
            int? purchasedConcurrency,
            int? concurrencyPurchaseLimit,
            int? remainingPurchaseLimit,
            bool? concurrencyBurstEnabled,
            int? concurrencyBurstLimit)
        {
            this.CurrentConcurrency = currentConcurrency;
            this.ConcurrencyLimit = concurrencyLimit;
            this.BaseConcurrency = baseConcurrency;
            this.PurchasedConcurrency = purchasedConcurrency;
            this.ConcurrencyPurchaseLimit = concurrencyPurchaseLimit;
            this.RemainingPurchaseLimit = remainingPurchaseLimit;
            this.ConcurrencyBurstEnabled = concurrencyBurstEnabled;
            this.ConcurrencyBurstLimit = concurrencyBurstLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetConcurrencyResponse" /> class.
        /// </summary>
        public GetConcurrencyResponse()
        {
        }
    }
}