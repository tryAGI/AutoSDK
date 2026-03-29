//HintName: G.Models.ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType
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
    public static class ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType value)
        {
            return value switch
            {
                ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ScheduledMessagesListScheduledMessagesResponseScheduledMessageMessageMessageType.Message,
                _ => null,
            };
        }
    }
}