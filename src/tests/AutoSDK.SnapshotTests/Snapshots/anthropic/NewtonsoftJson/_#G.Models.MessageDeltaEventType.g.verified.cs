//HintName: G.Models.MessageDeltaEventType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: message_delta
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="message_delta")]
        MessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaEventType value)
        {
            return value switch
            {
                MessageDeltaEventType.MessageDelta => "message_delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "message_delta" => MessageDeltaEventType.MessageDelta,
                _ => null,
            };
        }
    }
}