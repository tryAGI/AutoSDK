//HintName: G.Models.PricingCalculatorResponse.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingCalculatorResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("calculateProductionApiServiceCost")]
        public global::G.PricingCalculatorResponseCalculateProductionApiServiceCost? CalculateProductionApiServiceCost { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorResponse" /> class.
        /// </summary>
        /// <param name="calculateProductionApiServiceCost"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorResponse(
            global::G.PricingCalculatorResponseCalculateProductionApiServiceCost? calculateProductionApiServiceCost)
        {
            this.CalculateProductionApiServiceCost = calculateProductionApiServiceCost;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorResponse" /> class.
        /// </summary>
        public PricingCalculatorResponse()
        {
        }
    }
}