//HintName: G.Models.InitSessionTransportProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum InitSessionTransportProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Livekit,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InitSessionTransportProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InitSessionTransportProvider value)
        {
            return value switch
            {
                InitSessionTransportProvider.Livekit => "livekit",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InitSessionTransportProvider? ToEnum(string value)
        {
            return value switch
            {
                "livekit" => InitSessionTransportProvider.Livekit,
                _ => null,
            };
        }
    }
}