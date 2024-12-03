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
        IMAGEGENERATION,
        /// <summary>
        /// 
        /// </summary>
        FANTASYAVATARGENERATION,
        /// <summary>
        /// 
        /// </summary>
        MOTIONGENERATION,
        /// <summary>
        /// 
        /// </summary>
        LCMGENERATION,
        /// <summary>
        /// 
        /// </summary>
        MODELTRAINING,
        /// <summary>
        /// 
        /// </summary>
        TEXTUREGENERATION,
        /// <summary>
        /// 
        /// </summary>
        UNIVERSALUPSCALER,
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
                PricingCalculatorServices.IMAGEGENERATION => "IMAGE_GENERATION",
                PricingCalculatorServices.FANTASYAVATARGENERATION => "FANTASY_AVATAR_GENERATION",
                PricingCalculatorServices.MOTIONGENERATION => "MOTION_GENERATION",
                PricingCalculatorServices.LCMGENERATION => "LCM_GENERATION",
                PricingCalculatorServices.MODELTRAINING => "MODEL_TRAINING",
                PricingCalculatorServices.TEXTUREGENERATION => "TEXTURE_GENERATION",
                PricingCalculatorServices.UNIVERSALUPSCALER => "UNIVERSAL_UPSCALER",
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
                "IMAGE_GENERATION" => PricingCalculatorServices.IMAGEGENERATION,
                "FANTASY_AVATAR_GENERATION" => PricingCalculatorServices.FANTASYAVATARGENERATION,
                "MOTION_GENERATION" => PricingCalculatorServices.MOTIONGENERATION,
                "LCM_GENERATION" => PricingCalculatorServices.LCMGENERATION,
                "MODEL_TRAINING" => PricingCalculatorServices.MODELTRAINING,
                "TEXTURE_GENERATION" => PricingCalculatorServices.TEXTUREGENERATION,
                "UNIVERSAL_UPSCALER" => PricingCalculatorServices.UNIVERSALUPSCALER,
                _ => null,
            };
        }
    }
}