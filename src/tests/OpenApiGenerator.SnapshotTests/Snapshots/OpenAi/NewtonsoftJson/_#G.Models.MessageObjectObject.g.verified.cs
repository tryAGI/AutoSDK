//HintName: G.Models.MessageObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.message`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message")]
        Threadmessage,
    }

    public static class MessageObjectObjectExtensions
    {
        public static string ToValueString(this MessageObjectObject value)
        {
            return value switch
            {
                MessageObjectObject.Threadmessage => "thread.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread.message" => MessageObjectObject.Threadmessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => MessageObjectObject.Threadmessage,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}