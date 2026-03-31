//HintName: G.Models.JoinLivekitRoomRequestTransportProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum JoinLivekitRoomRequestTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class JoinLivekitRoomRequestTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this JoinLivekitRoomRequestTransportProvider value)
        {
            return value switch
            {
                JoinLivekitRoomRequestTransportProvider.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static JoinLivekitRoomRequestTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => JoinLivekitRoomRequestTransportProvider.Livekit,
                _ => null,
            };
        }
    }
}