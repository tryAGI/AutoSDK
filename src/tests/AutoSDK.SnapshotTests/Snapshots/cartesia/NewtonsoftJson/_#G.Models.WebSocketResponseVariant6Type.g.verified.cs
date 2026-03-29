//HintName: G.Models.WebSocketResponseVariant6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum WebSocketResponseVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="phoneme_timestamps")]
        PhonemeTimestamps,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSocketResponseVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSocketResponseVariant6Type value)
        {
            return value switch
            {
                WebSocketResponseVariant6Type.PhonemeTimestamps => "phoneme_timestamps",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSocketResponseVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "phoneme_timestamps" => WebSocketResponseVariant6Type.PhonemeTimestamps,
                _ => null,
            };
        }
    }
}