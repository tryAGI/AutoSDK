//HintName: G.Models.MessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Object type.<br/>
    /// For Messages, this is always `"message"`.<br/>
    /// Default Value: message
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message")]
        Message,
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
                MessageType.Message => "message",
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
                "message" => MessageType.Message,
                _ => null,
            };
        }
    }
}