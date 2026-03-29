//HintName: G.Models.ServerMessagePhoneCallControlType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "phone-call-control" is an advanced type of message.<br/>
    /// When it is requested in `assistant.serverMessages`, the hangup and forwarding responsibilities are delegated to your server. Vapi will no longer do the actual transfer and hangup.
    /// </summary>
    public enum ServerMessagePhoneCallControlType
    {
        /// <summary>
        /// 
        /// </summary>
        PhoneCallControl,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessagePhoneCallControlTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessagePhoneCallControlType value)
        {
            return value switch
            {
                ServerMessagePhoneCallControlType.PhoneCallControl => "phone-call-control",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessagePhoneCallControlType? ToEnum(string value)
        {
            return value switch
            {
                "phone-call-control" => ServerMessagePhoneCallControlType.PhoneCallControl,
                _ => null,
            };
        }
    }
}