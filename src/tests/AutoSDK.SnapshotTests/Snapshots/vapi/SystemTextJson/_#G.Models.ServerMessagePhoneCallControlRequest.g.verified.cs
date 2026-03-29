//HintName: G.Models.ServerMessagePhoneCallControlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the request to control the phone call.
    /// </summary>
    public enum ServerMessagePhoneCallControlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        Forward,
        /// <summary>
        /// 
        /// </summary>
        HangUp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ServerMessagePhoneCallControlRequestExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ServerMessagePhoneCallControlRequest value)
        {
            return value switch
            {
                ServerMessagePhoneCallControlRequest.Forward => "forward",
                ServerMessagePhoneCallControlRequest.HangUp => "hang-up",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ServerMessagePhoneCallControlRequest? ToEnum(string value)
        {
            return value switch
            {
                "forward" => ServerMessagePhoneCallControlRequest.Forward,
                "hang-up" => ServerMessagePhoneCallControlRequest.HangUp,
                _ => null,
            };
        }
    }
}