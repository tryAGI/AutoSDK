//HintName: G.Models.MessageStreamEventVariant2Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageStreamEventVariant2Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadMessageInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventVariant2EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventVariant2Event value)
        {
            return value switch
            {
                MessageStreamEventVariant2Event.ThreadMessageInProgress => "thread.message.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventVariant2Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.in_progress" => MessageStreamEventVariant2Event.ThreadMessageInProgress,
                _ => null,
            };
        }
    }
}