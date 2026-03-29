//HintName: G.Models.InitLiveKitRoomTransportProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InitLiveKitRoomTransportProvider
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
    public static class InitLiveKitRoomTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitLiveKitRoomTransportProvider value)
        {
            return value switch
            {
                InitLiveKitRoomTransportProvider.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitLiveKitRoomTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => InitLiveKitRoomTransportProvider.Livekit,
                _ => null,
            };
        }
    }
}