//HintName: G.Models.WarmTransferStaticMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WarmTransferStaticMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        StaticMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WarmTransferStaticMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WarmTransferStaticMessageType value)
        {
            return value switch
            {
                WarmTransferStaticMessageType.StaticMessage => "static_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WarmTransferStaticMessageType? ToEnum(string value)
        {
            return value switch
            {
                "static_message" => WarmTransferStaticMessageType.StaticMessage,
                _ => null,
            };
        }
    }
}