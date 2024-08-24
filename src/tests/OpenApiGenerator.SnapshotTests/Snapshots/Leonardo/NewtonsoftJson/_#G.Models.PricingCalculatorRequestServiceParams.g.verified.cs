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
        [global::Newtonsoft.Json.JsonProperty("IMAGE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsIMAGEGENERATION? IMAGEGENERATION { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("FANTASY_AVATAR_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsFANTASYAVATARGENERATION? FANTASYAVATARGENERATION { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MOTION_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsMOTIONGENERATION? MOTIONGENERATION { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("LCM_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsLCMGENERATION? LCMGENERATION { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MODEL_TRAINING")]
        public global::G.PricingCalculatorRequestServiceParamsMODELTRAINING? MODELTRAINING { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("TEXTURE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsTEXTUREGENERATION? TEXTUREGENERATION { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UNIVERSAL_UPSCALER")]
        public global::G.PricingCalculatorRequestServiceParamsUNIVERSALUPSCALER? UNIVERSALUPSCALER { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}