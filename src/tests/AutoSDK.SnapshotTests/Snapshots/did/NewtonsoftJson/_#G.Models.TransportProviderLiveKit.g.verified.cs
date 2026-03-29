//HintName: G.Models.TransportProviderLiveKit.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TransportProviderLiveKit
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="livekit")]
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TransportProviderLiveKitExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TransportProviderLiveKit value)
        {
            return value switch
            {
                TransportProviderLiveKit.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TransportProviderLiveKit? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => TransportProviderLiveKit.Livekit,
                _ => null,
            };
        }
    }
}