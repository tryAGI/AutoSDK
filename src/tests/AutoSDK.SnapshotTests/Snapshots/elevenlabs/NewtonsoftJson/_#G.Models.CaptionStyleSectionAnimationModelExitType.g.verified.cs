//HintName: G.Models.CaptionStyleSectionAnimationModelExitType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleSectionAnimationModelExitType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fade")]
        Fade,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scale")]
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
                CaptionStyleSectionAnimationModelExitType.None => "none",
                CaptionStyleSectionAnimationModelExitType.Fade => "fade",
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
                "none" => CaptionStyleSectionAnimationModelExitType.None,
                "fade" => CaptionStyleSectionAnimationModelExitType.Fade,
                "scale" => CaptionStyleSectionAnimationModelExitType.Scale,
                _ => null,
            };
        }
    }
}