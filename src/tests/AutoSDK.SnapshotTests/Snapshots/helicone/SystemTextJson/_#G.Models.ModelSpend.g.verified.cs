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
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promptTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double PromptTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completionTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CompletionTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheReadTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CacheReadTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheWriteTokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double CacheWriteTokens { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pricing")]
        public global::G.ModelSpendPricing? Pricing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("subtotal")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Subtotal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("discountPercent")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double DiscountPercent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cacheAdjustment")]
        public double? CacheAdjustment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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