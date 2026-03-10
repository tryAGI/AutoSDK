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
        None,
        /// <summary>
        /// 
        /// </summary>
        Fade,
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
                CaptionStyleCharacterAnimationModelExitType.None => "none",
                CaptionStyleCharacterAnimationModelExitType.Fade => "fade",
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
                "none" => CaptionStyleCharacterAnimationModelExitType.None,
                "fade" => CaptionStyleCharacterAnimationModelExitType.Fade,
                _ => null,
            };
        }
    }
}