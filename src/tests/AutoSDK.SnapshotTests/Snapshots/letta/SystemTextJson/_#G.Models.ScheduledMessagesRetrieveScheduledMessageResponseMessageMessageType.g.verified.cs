//HintName: G.Models.ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType value)
        {
            return value switch
            {
                ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType? ToEnum(string value)
        {
            return value switch
            {
                "message" => ScheduledMessagesRetrieveScheduledMessageResponseMessageMessageType.Message,
                _ => null,
            };
        }
    }
}