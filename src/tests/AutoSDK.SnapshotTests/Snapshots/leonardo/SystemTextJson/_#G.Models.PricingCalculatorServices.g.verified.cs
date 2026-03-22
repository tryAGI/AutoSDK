//HintName: G.Models.PricingCalculatorServices.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The services to be chosen for calculating the API credit cost.
    /// </summary>
    public enum PricingCalculatorServices
    {
        /// <summary>
        /// 
        /// </summary>
        FantasyAvatarGeneration,
        /// <summary>
        /// 
        /// </summary>
        ImageGeneration,
        /// <summary>
        /// 
        /// </summary>
        LcmGeneration,
        /// <summary>
        /// 
        /// </summary>
        ModelTraining,
        /// <summary>
        /// 
        /// </summary>
        MotionGeneration,
        /// <summary>
        /// 
        /// </summary>
        TextureGeneration,
        /// <summary>
        /// 
        /// </summary>
        UniversalUpscaler,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PricingCalculatorServicesExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PricingCalculatorServices value)
        {
            return value switch
            {
                PricingCalculatorServices.FantasyAvatarGeneration => "FANTASY_AVATAR_GENERATION",
                PricingCalculatorServices.ImageGeneration => "IMAGE_GENERATION",
                PricingCalculatorServices.LcmGeneration => "LCM_GENERATION",
                PricingCalculatorServices.ModelTraining => "MODEL_TRAINING",
                PricingCalculatorServices.MotionGeneration => "MOTION_GENERATION",
                PricingCalculatorServices.TextureGeneration => "TEXTURE_GENERATION",
                PricingCalculatorServices.UniversalUpscaler => "UNIVERSAL_UPSCALER",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PricingCalculatorServices? ToEnum(string value)
        {
            return value switch
            {
                "FANTASY_AVATAR_GENERATION" => PricingCalculatorServices.FantasyAvatarGeneration,
                "IMAGE_GENERATION" => PricingCalculatorServices.ImageGeneration,
                "LCM_GENERATION" => PricingCalculatorServices.LcmGeneration,
                "MODEL_TRAINING" => PricingCalculatorServices.ModelTraining,
                "MOTION_GENERATION" => PricingCalculatorServices.MotionGeneration,
                "TEXTURE_GENERATION" => PricingCalculatorServices.TextureGeneration,
                "UNIVERSAL_UPSCALER" => PricingCalculatorServices.UniversalUpscaler,
                _ => null,
            };
        }
    }
}