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
        public global::G.PricingCalculatorRequestServiceParamsImageGeneration? ImageGeneration { get; set; }

        /// <summary>
        /// Parameters for FANTASY_AVATAR_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("FANTASY_AVATAR_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsFantasyAvatarGeneration? FantasyAvatarGeneration { get; set; }

        /// <summary>
        /// Parameters for MOTION_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MOTION_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsMotionGeneration? MotionGeneration { get; set; }

        /// <summary>
        /// Parameters for LCM_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LCM_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsLcmGeneration? LcmGeneration { get; set; }

        /// <summary>
        /// Parameters for MODEL_TRAINING service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("MODEL_TRAINING")]
        public global::G.PricingCalculatorRequestServiceParamsModelTraining? ModelTraining { get; set; }

        /// <summary>
        /// Parameters for TEXTURE_GENERATION service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("TEXTURE_GENERATION")]
        public global::G.PricingCalculatorRequestServiceParamsTextureGeneration? TextureGeneration { get; set; }

        /// <summary>
        /// Parameters for UNIVERSAL_UPSCALER service
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("UNIVERSAL_UPSCALER")]
        public global::G.PricingCalculatorRequestServiceParamsUniversalUpscaler? UniversalUpscaler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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