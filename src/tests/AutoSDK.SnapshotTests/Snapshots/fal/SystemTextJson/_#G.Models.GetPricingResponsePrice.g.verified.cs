//HintName: G.Models.GetPricingResponsePrice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Pricing information for a specific model endpoint. Most models use output-based pricing (e.g., per image/video with proportional adjustments for resolution/length). Some models use GPU-based pricing depending on architecture.
    /// </summary>
    public sealed partial class GetPricingResponsePrice
    {
        /// <summary>
        /// Endpoint identifier (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EndpointId { get; set; }

        /// <summary>
        /// Base price per billing unit (often per generated output; may be per GPU-second for some models) in the specified currency
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_price")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double UnitPrice { get; set; }

        /// <summary>
        /// Unit of measurement for billing: 'image', 'video', or provider-specific GPU/compute unit when applicable. Most models use output-based pricing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Unit { get; set; }

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("currency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Currency { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingResponsePrice" /> class.
        /// </summary>
        /// <param name="endpointId">
        /// Endpoint identifier (e.g., 'fal-ai/wan/v2.2-a14b/text-to-video', 'fal-ai/minimax/video-01/image-to-video')
        /// </param>
        /// <param name="unitPrice">
        /// Base price per billing unit (often per generated output; may be per GPU-second for some models) in the specified currency
        /// </param>
        /// <param name="unit">
        /// Unit of measurement for billing: 'image', 'video', or provider-specific GPU/compute unit when applicable. Most models use output-based pricing.
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetPricingResponsePrice(
            string endpointId,
            double unitPrice,
            string unit,
            string currency)
        {
            this.EndpointId = endpointId ?? throw new global::System.ArgumentNullException(nameof(endpointId));
            this.UnitPrice = unitPrice;
            this.Unit = unit ?? throw new global::System.ArgumentNullException(nameof(unit));
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetPricingResponsePrice" /> class.
        /// </summary>
        public GetPricingResponsePrice()
        {
        }
    }
}