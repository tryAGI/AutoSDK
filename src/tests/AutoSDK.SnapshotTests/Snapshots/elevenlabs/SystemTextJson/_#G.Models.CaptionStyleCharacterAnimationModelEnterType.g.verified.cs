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
        Fade,
        /// <summary>
        /// 
        /// </summary>
        None,
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
                CaptionStyleCharacterAnimationModelEnterType.Fade => "fade",
                CaptionStyleCharacterAnimationModelEnterType.None => "none",
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
                "fade" => CaptionStyleCharacterAnimationModelEnterType.Fade,
                "none" => CaptionStyleCharacterAnimationModelEnterType.None,
                _ => null,
            };
        }
    }
}