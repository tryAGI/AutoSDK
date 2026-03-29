//HintName: G.Models.EstimatePricingRequestVariant2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Unit price estimate: Calculates cost based on unit price × billing units. Useful for estimating costs when you know the expected output quantity.
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant2
    {
        /// <summary>
        /// Estimate type: unit price calculation based on billing units
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estimate_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.EstimatePricingRequestVariant2EstimateTypeJsonConverter))]
        public global::G.EstimatePricingRequestVariant2EstimateType EstimateType { get; set; }

        /// <summary>
        /// Map of endpoint IDs to unit quantities
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("endpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::G.EstimatePricingRequestVariant2Endpoints2> Endpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant2" /> class.
        /// </summary>
        /// <param name="endpoints">
        /// Map of endpoint IDs to unit quantities
        /// </param>
        /// <param name="estimateType">
        /// Estimate type: unit price calculation based on billing units
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant2(
            global::System.Collections.Generic.Dictionary<string, global::G.EstimatePricingRequestVariant2Endpoints2> endpoints,
            global::G.EstimatePricingRequestVariant2EstimateType estimateType)
        {
            this.EstimateType = estimateType;
            this.Endpoints = endpoints ?? throw new global::System.ArgumentNullException(nameof(endpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant2" /> class.
        /// </summary>
        public EstimatePricingRequestVariant2()
        {
        }
    }
}