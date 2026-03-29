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
        [global::Newtonsoft.Json.JsonProperty("call_quantity", Required = global::Newtonsoft.Json.Required.Always)]
        public int CallQuantity { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimatePricingRequestVariant1Endpoints2" /> class.
        /// </summary>
        /// <param name="callQuantity">
        /// Number of API calls to estimate (regardless of units per call)
        /// </param>
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