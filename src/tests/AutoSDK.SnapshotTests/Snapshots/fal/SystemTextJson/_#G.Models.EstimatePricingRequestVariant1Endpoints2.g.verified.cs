//HintName: G.Models.EstimatePricingRequestVariant1Endpoints2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimatePricingRequestVariant1Endpoints2
    {
        /// <summary>
        /// Number of API calls to estimate (regardless of units per call)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_quantity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CallQuantity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1Endpoints2" /> class.
        /// </summary>
        /// <param name="callQuantity">
        /// Number of API calls to estimate (regardless of units per call)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimatePricingRequestVariant1Endpoints2(
            int callQuantity)
        {
            this.CallQuantity = callQuantity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1Endpoints2" /> class.
        /// </summary>
        public EstimatePricingRequestVariant1Endpoints2()
        {
        }
    }
}