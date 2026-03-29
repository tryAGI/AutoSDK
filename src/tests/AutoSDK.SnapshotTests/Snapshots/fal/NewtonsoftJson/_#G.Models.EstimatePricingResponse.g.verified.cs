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
        [global::Newtonsoft.Json.JsonProperty("estimate_type", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.EstimatePricingResponseEstimateType EstimateType { get; set; } = default!;

        /// <summary>
        /// Total estimated cost across all endpoints
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("total_cost", Required = global::Newtonsoft.Json.Required.Always)]
        public double TotalCost { get; set; } = default!;

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