//HintName: G.Models.MessageStreamEventVariant1Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageStreamEventVariant1Event
    {
        /// <summary>
        /// 
        /// </summary>
        ThreadMessageCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventVariant1EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventVariant1Event value)
        {
            return value switch
            {
                MessageStreamEventVariant1Event.ThreadMessageCreated => "thread.message.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventVariant1Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.created" => MessageStreamEventVariant1Event.ThreadMessageCreated,
                _ => null,
            };
        }
    }
}