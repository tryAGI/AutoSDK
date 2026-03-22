//HintName: G.Models.CaptionStyleSectionAnimationModelExitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleSectionAnimationModelExitType
    {
        /// <summary>
        /// 
        /// </summary>
        Fade,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Scale,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleSectionAnimationModelExitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleSectionAnimationModelExitType value)
        {
            return value switch
            {
                CaptionStyleSectionAnimationModelExitType.Fade => "fade",
                CaptionStyleSectionAnimationModelExitType.None => "none",
                CaptionStyleSectionAnimationModelExitType.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleSectionAnimationModelExitType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleSectionAnimationModelExitType.Fade,
                "none" => CaptionStyleSectionAnimationModelExitType.None,
                "scale" => CaptionStyleSectionAnimationModelExitType.Scale,
                _ => null,
            };
        }
    }
}