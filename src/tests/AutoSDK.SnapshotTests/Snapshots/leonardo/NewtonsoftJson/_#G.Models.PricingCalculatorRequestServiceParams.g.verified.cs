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
        public global::G.PricingCalculatorRequestServiceParamsImageGeneration? ImageGeneration { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("FANTASY_AVATAR_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? FantasyAvatarGeneration { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MOTION_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsMotionGeneration? MotionGeneration { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("LCM_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsLcmGeneration? LcmGeneration { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("MODEL_TRAINING")]
        public global::G.PricingCalculatorRequestServiceParamsModelTraining? ModelTraining { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("TEXTURE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsTextureGeneration? TextureGeneration { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("UNIVERSAL_UPSCALER")]
        public global::G.PricingCalculatorRequestServiceParamsUniversalUpscaler? UniversalUpscaler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        /// <param name="imageGeneration">
        /// Parameters for IMAGE_GENERATION service
        /// </param>
        /// <param name="fantasyAvatarGeneration">
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </param>
        /// <param name="motionGeneration">
        /// Parameters for MOTION_GENERATION service
        /// </param>
        /// <param name="lcmGeneration">
        /// Parameters for LCM_GENERATION service
        /// </param>
        /// <param name="modelTraining">
        /// Parameters for MODEL_TRAINING service
        /// </param>
        /// <param name="textureGeneration">
        /// Parameters for TEXTURE_GENERATION service
        /// </param>
        /// <param name="universalUpscaler">
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </param>
        public PricingCalculatorRequestServiceParams(
            global::G.PricingCalculatorRequestServiceParamsImageGeneration? imageGeneration,
            global::G.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? fantasyAvatarGeneration,
            global::G.PricingCalculatorRequestServiceParamsMotionGeneration? motionGeneration,
            global::G.PricingCalculatorRequestServiceParamsLcmGeneration? lcmGeneration,
            global::G.PricingCalculatorRequestServiceParamsModelTraining? modelTraining,
            global::G.PricingCalculatorRequestServiceParamsTextureGeneration? textureGeneration,
            global::G.PricingCalculatorRequestServiceParamsUniversalUpscaler? universalUpscaler)
        {
            this.ImageGeneration = imageGeneration;
            this.FantasyAvatarGeneration = fantasyAvatarGeneration;
            this.MotionGeneration = motionGeneration;
            this.LcmGeneration = lcmGeneration;
            this.ModelTraining = modelTraining;
            this.TextureGeneration = textureGeneration;
            this.UniversalUpscaler = universalUpscaler;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PricingCalculatorRequestServiceParams" /> class.
        /// </summary>
        public PricingCalculatorRequestServiceParams()
        {
        }
    }
}