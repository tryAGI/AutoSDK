//HintName: G.Models.CaptionStyleSectionAnimationModelEnterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleSectionAnimationModelEnterType
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
    public static class CaptionStyleSectionAnimationModelEnterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleSectionAnimationModelEnterType value)
        {
            return value switch
            {
                CaptionStyleSectionAnimationModelEnterType.None => "none",
                CaptionStyleSectionAnimationModelEnterType.Fade => "fade",
                CaptionStyleSectionAnimationModelEnterType.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleSectionAnimationModelEnterType? ToEnum(string value)
        {
            return value switch
            {
                "none" => CaptionStyleSectionAnimationModelEnterType.None,
                "fade" => CaptionStyleSectionAnimationModelEnterType.Fade,
                "scale" => CaptionStyleSectionAnimationModelEnterType.Scale,
                _ => null,
            };
        }
    }
}