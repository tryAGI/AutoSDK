//HintName: G.Models.MessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - MESSAGE_TYPE_TEXT: text
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageType
    {
        /// <summary>
        /// text
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MESSAGE_TYPE_TEXT")]
        TEXT,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageType value)
        {
            return value switch
            {
                MessageType.TEXT => "MESSAGE_TYPE_TEXT",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageType? ToEnum(string value)
        {
            return value switch
            {
                "MESSAGE_TYPE_TEXT" => MessageType.TEXT,
                _ => null,
            };
        }
    }
}