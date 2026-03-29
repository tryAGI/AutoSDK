//HintName: G.Models.MessageStreamEventVariant3Event.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageStreamEventVariant3Event
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.delta")]
        ThreadMessageDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageStreamEventVariant3EventExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageStreamEventVariant3Event value)
        {
            return value switch
            {
                MessageStreamEventVariant3Event.ThreadMessageDelta => "thread.message.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageStreamEventVariant3Event? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.delta" => MessageStreamEventVariant3Event.ThreadMessageDelta,
                _ => null,
            };
        }
    }
}