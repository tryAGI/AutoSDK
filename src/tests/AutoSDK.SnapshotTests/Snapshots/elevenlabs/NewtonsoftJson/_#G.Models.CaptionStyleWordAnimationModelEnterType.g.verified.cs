//HintName: G.Models.CaptionStyleWordAnimationModelEnterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CaptionStyleWordAnimationModelEnterType
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
    public static class CaptionStyleWordAnimationModelEnterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CaptionStyleWordAnimationModelEnterType value)
        {
            return value switch
            {
                CaptionStyleWordAnimationModelEnterType.None => "none",
                CaptionStyleWordAnimationModelEnterType.Fade => "fade",
                CaptionStyleWordAnimationModelEnterType.Scale => "scale",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CaptionStyleWordAnimationModelEnterType? ToEnum(string value)
        {
            return value switch
            {
                "none" => CaptionStyleWordAnimationModelEnterType.None,
                "fade" => CaptionStyleWordAnimationModelEnterType.Fade,
                "scale" => CaptionStyleWordAnimationModelEnterType.Scale,
                _ => null,
            };
        }
    }
}