//HintName: G.Models.PricingCalculatorRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PricingCalculatorRequest
    {
        /// <summary>
        /// The services to be chosen for calculating the API credit cost.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("service")]
        public global::G.PricingCalculatorServices? Service { get; set; }

        /// <summary>
        /// Parameters for the service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("serviceParams")]
        public global::G.PricingCalculatorRequestServiceParams? ServiceParams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}