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
        None,
        /// <summary>
        /// 
        /// </summary>
        Fade,
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
                CaptionStyleWordAnimationModelExitType.None => "none",
                CaptionStyleWordAnimationModelExitType.Fade => "fade",
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
                "none" => CaptionStyleWordAnimationModelExitType.None,
                "fade" => CaptionStyleWordAnimationModelExitType.Fade,
                "scale" => CaptionStyleWordAnimationModelExitType.Scale,
                _ => null,
            };
        }
    }
}