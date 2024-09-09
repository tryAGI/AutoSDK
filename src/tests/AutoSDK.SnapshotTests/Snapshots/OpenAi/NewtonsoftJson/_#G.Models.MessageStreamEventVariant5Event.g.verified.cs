//HintName: G.Models.MessageStreamEventVariant5Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStreamEventVariant5Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.incomplete")]
        ThreadMessageIncomplete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventVariant5EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventVariant5Event value)
        {
            return value switch
            {
                MessageStreamEventVariant5Event.ThreadMessageIncomplete => "thread.message.incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventVariant5Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.incomplete" => MessageStreamEventVariant5Event.ThreadMessageIncomplete,
                _ => null,
            };
        }
    }
}