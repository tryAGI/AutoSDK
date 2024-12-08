//HintName: G.Models.MessageStopEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_stop
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStopEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_stop")]
        MessageStop,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStopEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStopEventType value)
        {
            return value switch
            {
                MessageStopEventType.MessageStop => "message_stop",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStopEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_stop" => MessageStopEventType.MessageStop,
                _ => null,
            };
        }
    }
}