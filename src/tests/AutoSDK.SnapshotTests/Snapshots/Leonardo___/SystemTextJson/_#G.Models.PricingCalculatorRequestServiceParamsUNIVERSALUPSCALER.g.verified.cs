//HintName: G.Models.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for UNIVERSAL_UPSCALER service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER
    {
        /// <summary>
        /// The maximum upscaled image size is 20 megapixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("megapixel")]
        public int? Megapixel { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER" /> class.
        /// </summary>
        /// <param name="megapixel">
        /// The maximum upscaled image size is 20 megapixels.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER(
            int? megapixel)
        {
            this.Megapixel = megapixel;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER()
        {
        }
    }
}