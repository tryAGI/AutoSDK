//HintName: G.Models.CaptionStyleCharacterAnimationModelExitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CaptionStyleCharacterAnimationModelExitType
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
    public static class CaptionStyleCharacterAnimationModelExitTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleCharacterAnimationModelExitType value)
        {
            return value switch
            {
                CaptionStyleCharacterAnimationModelExitType.Fade => "fade",
                CaptionStyleCharacterAnimationModelExitType.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleCharacterAnimationModelExitType? ToEnum(string value)
        {
            return value switch
            {
                "fade" => CaptionStyleCharacterAnimationModelExitType.Fade,
                "none" => CaptionStyleCharacterAnimationModelExitType.None,
                _ => null,
            };
        }
    }
}