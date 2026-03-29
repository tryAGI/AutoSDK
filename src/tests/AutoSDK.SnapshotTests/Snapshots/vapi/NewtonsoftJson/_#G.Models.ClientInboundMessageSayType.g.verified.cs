//HintName: G.Models.ClientInboundMessageSayType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "say" message to make the assistant say something.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientInboundMessageSayType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="say")]
        Say,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageSayTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageSayType value)
        {
            return value switch
            {
                ClientInboundMessageSayType.Say => "say",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageSayType? ToEnum(string value)
        {
            return value switch
            {
                "say" => ClientInboundMessageSayType.Say,
                _ => null,
            };
        }
    }
}