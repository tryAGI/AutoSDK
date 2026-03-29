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
        [global::Newtonsoft.Json.JsonProperty("endpoint_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string EndpointId { get; set; } = default!;

        /// <summary>
        /// Base price per billing unit (often per generated output; may be per GPU-second for some models) in the specified currency
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit_price", Required = global::Newtonsoft.Json.Required.Always)]
        public double UnitPrice { get; set; } = default!;

        /// <summary>
        /// Unit of measurement for billing: 'image', 'video', or provider-specific GPU/compute unit when applicable. Most models use output-based pricing.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("unit", Required = global::Newtonsoft.Json.Required.Always)]
        public string Unit { get; set; } = default!;

        /// <summary>
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("currency", Required = global::Newtonsoft.Json.Required.Always)]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
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