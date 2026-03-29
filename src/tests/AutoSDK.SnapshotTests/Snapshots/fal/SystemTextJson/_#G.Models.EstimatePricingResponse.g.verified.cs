//HintName: G.Models.EstimatePricingResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Cost estimation response with total cost<br/>
    /// Example: {"estimate_type":"historical_api_price","total_cost":3.75,"currency":"USD"}
    /// </summary>
    public sealed partial class EstimatePricingResponse
    {
        /// <summary>
        /// The type of estimate that was performed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimate_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EstimatePricingResponseEstimateTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.EstimatePricingResponseEstimateType EstimateType { get; set; }

        /// <summary>
        /// Total estimated cost across all endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_cost")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double TotalCost { get; set; }

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
        /// Initializes a new instance of the <see cref="EstimatePricingResponse" /> class.
        /// </summary>
        /// <param name="estimateType">
        /// The type of estimate that was performed
        /// </param>
        /// <param name="totalCost">
        /// Total estimated cost across all endpoints
        /// </param>
        /// <param name="currency">
        /// Three-letter currency code (ISO 4217, e.g., 'USD')
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingResponse(
            global::G.EstimatePricingResponseEstimateType estimateType,
            double totalCost,
            string currency)
        {
            this.EstimateType = estimateType;
            this.TotalCost = totalCost;
            this.Currency = currency ?? throw new global::System.ArgumentNullException(nameof(currency));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingResponse" /> class.
        /// </summary>
        public EstimatePricingResponse()
        {
        }
    }
}