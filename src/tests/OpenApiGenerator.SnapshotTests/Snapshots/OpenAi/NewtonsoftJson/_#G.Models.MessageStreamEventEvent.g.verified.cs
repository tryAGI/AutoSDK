//HintName: G.Models.MessageStreamEventEvent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStreamEventEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.created")]
        ThreadMessageCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventEventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventEvent value)
        {
            return value switch
            {
                MessageStreamEventEvent.ThreadMessageCreated => "thread.message.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventEvent? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.created" => MessageStreamEventEvent.ThreadMessageCreated,
                _ => null,
            };
        }
    }
}