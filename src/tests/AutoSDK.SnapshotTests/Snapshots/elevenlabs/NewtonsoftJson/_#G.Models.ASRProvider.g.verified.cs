//HintName: G.Models.ASRProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ASRProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="elevenlabs")]
        Elevenlabs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scribe_realtime")]
        ScribeRealtime,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ASRProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ASRProvider value)
        {
            return value switch
            {
                ASRProvider.Elevenlabs => "elevenlabs",
                ASRProvider.ScribeRealtime => "scribe_realtime",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ASRProvider? ToEnum(string value)
        {
            return value switch
            {
                "elevenlabs" => ASRProvider.Elevenlabs,
                "scribe_realtime" => ASRProvider.ScribeRealtime,
                _ => null,
            };
        }
    }
}