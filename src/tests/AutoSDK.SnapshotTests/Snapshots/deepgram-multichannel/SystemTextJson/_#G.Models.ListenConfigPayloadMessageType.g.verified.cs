//HintName: G.Models.ListenConfigPayloadMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListenConfigPayloadMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        ListenConfig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListenConfigPayloadMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListenConfigPayloadMessageType value)
        {
            return value switch
            {
                ListenConfigPayloadMessageType.ListenConfig => "listen_config",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListenConfigPayloadMessageType? ToEnum(string value)
        {
            return value switch
            {
                "listen_config" => ListenConfigPayloadMessageType.ListenConfig,
                _ => null,
            };
        }
    }
}