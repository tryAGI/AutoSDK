//HintName: G.Models.ModelSpend.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelSpend
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("model", Required = global::Newtonsoft.Json.Required.Always)]
        public string Model { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("provider", Required = global::Newtonsoft.Json.Required.Always)]
        public string Provider { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("promptTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double PromptTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("completionTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CompletionTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheReadTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CacheReadTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheWriteTokens", Required = global::Newtonsoft.Json.Required.Always)]
        public double CacheWriteTokens { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("pricing")]
        public global::G.ModelSpendPricing? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("subtotal", Required = global::Newtonsoft.Json.Required.Always)]
        public double Subtotal { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("discountPercent", Required = global::Newtonsoft.Json.Required.Always)]
        public double DiscountPercent { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total", Required = global::Newtonsoft.Json.Required.Always)]
        public double Total { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("cacheAdjustment")]
        public double? CacheAdjustment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpend" /> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="provider"></param>
        /// <param name="promptTokens"></param>
        /// <param name="completionTokens"></param>
        /// <param name="cacheReadTokens"></param>
        /// <param name="cacheWriteTokens"></param>
        /// <param name="subtotal"></param>
        /// <param name="discountPercent"></param>
        /// <param name="total"></param>
        /// <param name="pricing"></param>
        /// <param name="cacheAdjustment"></param>
        public ModelSpend(
            string model,
            string provider,
            double promptTokens,
            double completionTokens,
            double cacheReadTokens,
            double cacheWriteTokens,
            double subtotal,
            double discountPercent,
            double total,
            global::G.ModelSpendPricing? pricing,
            double? cacheAdjustment)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Provider = provider ?? throw new global::System.ArgumentNullException(nameof(provider));
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CacheReadTokens = cacheReadTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.Pricing = pricing;
            this.Subtotal = subtotal;
            this.DiscountPercent = discountPercent;
            this.Total = total;
            this.CacheAdjustment = cacheAdjustment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSpend" /> class.
        /// </summary>
        public ModelSpend()
        {
        }
    }
}