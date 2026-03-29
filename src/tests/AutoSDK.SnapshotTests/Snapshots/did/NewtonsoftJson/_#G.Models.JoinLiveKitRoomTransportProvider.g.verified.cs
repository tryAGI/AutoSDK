//HintName: G.Models.JoinLiveKitRoomTransportProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum JoinLiveKitRoomTransportProvider
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
    public static class JoinLiveKitRoomTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JoinLiveKitRoomTransportProvider value)
        {
            return value switch
            {
                JoinLiveKitRoomTransportProvider.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JoinLiveKitRoomTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => JoinLiveKitRoomTransportProvider.Livekit,
                _ => null,
            };
        }
    }
}