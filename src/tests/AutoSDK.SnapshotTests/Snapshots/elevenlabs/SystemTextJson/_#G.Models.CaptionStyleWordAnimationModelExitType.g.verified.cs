//HintName: G.Models.CaptionStyleWordAnimationModelExitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleWordAnimationModelExitType
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
    public static class CaptionStyleWordAnimationModelExitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleWordAnimationModelExitType value)
        {
            return value switch
            {
                CaptionStyleWordAnimationModelExitType.Fade => "fade",
                CaptionStyleWordAnimationModelExitType.None => "none",
                CaptionStyleWordAnimationModelExitType.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleWordAnimationModelExitType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleWordAnimationModelExitType.Fade,
                "none" => CaptionStyleWordAnimationModelExitType.None,
                "scale" => CaptionStyleWordAnimationModelExitType.Scale,
                _ => null,
            };
        }
    }
}