//HintName: G.Models.MessageStartEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_start
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStartEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_start")]
        MessageStart,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStartEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStartEventType value)
        {
            return value switch
            {
                MessageStartEventType.MessageStart => "message_start",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStartEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_start" => MessageStartEventType.MessageStart,
                _ => null,
            };
        }
    }
}