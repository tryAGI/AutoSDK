//HintName: G.Models.PricingCalculatorRequestServiceParams.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Parameters for the service
    /// </summary>
    public sealed partial class PricingCalculatorRequestServiceParams
    {
        /// <summary>
        /// Parameters for IMAGE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("IMAGE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? IMAGEGENERATION { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? FANTASYAVATARGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsMOTIONGENERATION? MOTIONGENERATION { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? LCMGENERATION { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::G.PricingCalculatorRequestServiceParamsMODELTRAINING? MODELTRAINING { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? TEXTUREGENERATION { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::G.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? UNIVERSALUPSCALER { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        /// <param name="iMAGEGENERATION">
        /// Parameters for IMAGE_GENERATION service
        /// </param>
        /// <param name="fANTASYAVATARGENERATION">
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </param>
        /// <param name="mOTIONGENERATION">
        /// Parameters for MOTION_GENERATION service
        /// </param>
        /// <param name="lCMGENERATION">
        /// Parameters for LCM_GENERATION service
        /// </param>
        /// <param name="mODELTRAINING">
        /// Parameters for MODEL_TRAINING service
        /// </param>
        /// <param name="tEXTUREGENERATION">
        /// Parameters for TEXTURE_GENERATION service
        /// </param>
        /// <param name="uNIVERSALUPSCALER">
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PricingCalculatorRequestServiceParams(
            global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? iMAGEGENERATION,
            global::G.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? fANTASYAVATARGENERATION,
            global::G.PricingCalculatorRequestServiceParamsMOTIONGENERATION? mOTIONGENERATION,
            global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? lCMGENERATION,
            global::G.PricingCalculatorRequestServiceParamsMODELTRAINING? mODELTRAINING,
            global::G.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? tEXTUREGENERATION,
            global::G.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? uNIVERSALUPSCALER)
        {
            this.IMAGEGENERATION = iMAGEGENERATION;
            this.FANTASYAVATARGENERATION = fANTASYAVATARGENERATION;
            this.MOTIONGENERATION = mOTIONGENERATION;
            this.LCMGENERATION = lCMGENERATION;
            this.MODELTRAINING = mODELTRAINING;
            this.TEXTUREGENERATION = tEXTUREGENERATION;
            this.UNIVERSALUPSCALER = uNIVERSALUPSCALER;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParams()
        {
        }
    }
}