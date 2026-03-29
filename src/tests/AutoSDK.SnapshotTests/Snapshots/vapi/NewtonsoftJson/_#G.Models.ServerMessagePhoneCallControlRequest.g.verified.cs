//HintName: G.Models.ServerMessagePhoneCallControlRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the request to control the phone call.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ServerMessagePhoneCallControlRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="forward")]
        Forward,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hang-up")]
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