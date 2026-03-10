//HintName: G.Models.CaptionStyleCharacterAnimationModelEnterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleCharacterAnimationModelEnterType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Fade,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CaptionStyleCharacterAnimationModelEnterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleCharacterAnimationModelEnterType value)
        {
            return value switch
            {
                CaptionStyleCharacterAnimationModelEnterType.None => "none",
                CaptionStyleCharacterAnimationModelEnterType.Fade => "fade",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleCharacterAnimationModelEnterType? ToEnum(string value)
        {
            return value switch
            {
                "none" => CaptionStyleCharacterAnimationModelEnterType.None,
                "fade" => CaptionStyleCharacterAnimationModelEnterType.Fade,
                _ => null,
            };
        }
    }
}