//HintName: G.Models.PricingCalculatorRequestServiceParamsTEXTUREGENERATION.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for TEXTURE_GENERATION service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsTEXTUREGENERATION
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("preview")]
        public bool? Preview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsTEXTUREGENERATION" /> class.
        /// </summary>
        /// <param name="preview"></param>
        public PricingCalculatorRequestServiceParamsTEXTUREGENERATION(
            bool? preview)
        {
            this.Preview = preview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsTEXTUREGENERATION" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsTEXTUREGENERATION()
        {
        }
    }
}