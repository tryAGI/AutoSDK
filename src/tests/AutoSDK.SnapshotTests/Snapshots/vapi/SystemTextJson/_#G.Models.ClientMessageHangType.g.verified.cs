//HintName: G.Models.ClientMessageHangType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the message. "hang" is sent when the assistant is hanging due to a delay. The delay can be caused by many factors, such as:<br/>
    /// - the model is too slow to respond<br/>
    /// - the voice is too slow to respond<br/>
    /// - the tool call is still waiting for a response from your server<br/>
    /// - etc.
    /// </summary>
    public enum ClientMessageHangType
    {
        /// <summary>
        /// 
        /// </summary>
        Hang,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ClientMessageHangTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClientMessageHangType value)
        {
            return value switch
            {
                ClientMessageHangType.Hang => "hang",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClientMessageHangType? ToEnum(string value)
        {
            return value switch
            {
                "hang" => ClientMessageHangType.Hang,
                _ => null,
            };
        }
    }
}