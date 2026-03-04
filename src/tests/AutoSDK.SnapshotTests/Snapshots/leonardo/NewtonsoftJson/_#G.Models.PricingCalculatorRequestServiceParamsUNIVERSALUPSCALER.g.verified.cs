//HintName: G.Models.PricingCalculatorRequestServiceParamsUniversalUpscaler.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for UNIVERSAL_UPSCALER service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsUniversalUpscaler
    {
        /// <summary>
        /// The maximum upscaled image size is 20 megapixels.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("megapixel")]
        public int? Megapixel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsUniversalUpscaler" /> class.
        /// </summary>
        /// <param name="megapixel">
        /// The maximum upscaled image size is 20 megapixels.
        /// </param>
        public PricingCalculatorRequestServiceParamsUniversalUpscaler(
            int? megapixel)
        {
            this.Megapixel = megapixel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsUniversalUpscaler" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsUniversalUpscaler()
        {
        }
    }
}