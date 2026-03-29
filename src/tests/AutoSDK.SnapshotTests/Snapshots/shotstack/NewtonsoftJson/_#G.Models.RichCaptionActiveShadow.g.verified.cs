//HintName: G.Models.RichCaptionActiveShadow.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum RichCaptionActiveShadow
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="none")]
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RichCaptionActiveShadowExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RichCaptionActiveShadow value)
        {
            return value switch
            {
                RichCaptionActiveShadow.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RichCaptionActiveShadow? ToEnum(string value)
        {
            return value switch
            {
                "none" => RichCaptionActiveShadow.None,
                _ => null,
            };
        }
    }
}