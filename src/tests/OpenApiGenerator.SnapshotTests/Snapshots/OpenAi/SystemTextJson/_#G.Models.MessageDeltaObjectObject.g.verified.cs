//HintName: G.Models.MessageDeltaObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.message.delta`.
    /// </summary>
    public enum MessageDeltaObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        Threadmessagedelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaObjectObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaObjectObject value)
        {
            return value switch
            {
                MessageDeltaObjectObject.Threadmessagedelta => "thread.message.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaObjectObject? ToEnum(string value)
        {
            return value switch
            {
                "thread.message.delta" => MessageDeltaObjectObject.Threadmessagedelta,
                _ => null,
            };
        }
    }
}