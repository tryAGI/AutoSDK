//HintName: G.Models.MessageObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.message`.
    /// </summary>
    public enum MessageObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        Threadmessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectObject value)
        {
            return value switch
            {
                MessageObjectObject.Threadmessage => "thread.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.message" => MessageObjectObject.Threadmessage,
                _ => null,
            };
        }
    }
}