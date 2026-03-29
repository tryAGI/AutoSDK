//HintName: G.Models.ClientInboundMessageControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. Send "control" message to control the assistant. `control` options are:<br/>
    /// - "mute-assistant" - mute the assistant<br/>
    /// - "unmute-assistant" - unmute the assistant<br/>
    /// - "mute-customer" - mute the user<br/>
    /// - "unmute-customer" - unmute the user<br/>
    /// - "say-first-message" - say the first message (this is used when video recording is enabled and the conversation is only started once the client side kicks off the recording)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClientInboundMessageControlType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="control")]
        Control,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageControlType value)
        {
            return value switch
            {
                ClientInboundMessageControlType.Control => "control",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageControlType? ToEnum(string value)
        {
            return value switch
            {
                "control" => ClientInboundMessageControlType.Control,
                _ => null,
            };
        }
    }
}