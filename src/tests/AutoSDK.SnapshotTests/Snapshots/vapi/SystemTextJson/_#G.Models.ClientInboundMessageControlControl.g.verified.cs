//HintName: G.Models.ClientInboundMessageControlControl.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the control action
    /// </summary>
    public enum ClientInboundMessageControlControl
    {
        /// <summary>
        /// 
        /// </summary>
        MuteAssistant,
        /// <summary>
        /// 
        /// </summary>
        MuteCustomer,
        /// <summary>
        /// 
        /// </summary>
        SayFirstMessage,
        /// <summary>
        /// 
        /// </summary>
        UnmuteAssistant,
        /// <summary>
        /// 
        /// </summary>
        UnmuteCustomer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientInboundMessageControlControlExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientInboundMessageControlControl value)
        {
            return value switch
            {
                ClientInboundMessageControlControl.MuteAssistant => "mute-assistant",
                ClientInboundMessageControlControl.MuteCustomer => "mute-customer",
                ClientInboundMessageControlControl.SayFirstMessage => "say-first-message",
                ClientInboundMessageControlControl.UnmuteAssistant => "unmute-assistant",
                ClientInboundMessageControlControl.UnmuteCustomer => "unmute-customer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientInboundMessageControlControl? ToEnum(string value)
        {
            return value switch
            {
                "mute-assistant" => ClientInboundMessageControlControl.MuteAssistant,
                "mute-customer" => ClientInboundMessageControlControl.MuteCustomer,
                "say-first-message" => ClientInboundMessageControlControl.SayFirstMessage,
                "unmute-assistant" => ClientInboundMessageControlControl.UnmuteAssistant,
                "unmute-customer" => ClientInboundMessageControlControl.UnmuteCustomer,
                _ => null,
            };
        }
    }
}