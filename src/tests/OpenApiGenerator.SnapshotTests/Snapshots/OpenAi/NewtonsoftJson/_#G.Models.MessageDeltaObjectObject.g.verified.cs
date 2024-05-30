//HintName: G.Models.MessageDeltaObjectObject.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `thread.message.delta`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaObjectObject
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="thread.message.delta")]
        Threadmessagedelta,
    }

    public static class MessageDeltaObjectObjectExtensions
    {
        public static string ToValueString(this MessageDeltaObjectObject value)
        {
            return value switch
            {
                MessageDeltaObjectObject.Threadmessagedelta => "thread.message.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaObjectObject ToEnum(string value)
        {
            return value switch
            {
                "thread.message.delta" => MessageDeltaObjectObject.Threadmessagedelta,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaObjectObject ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaObjectObject.Threadmessagedelta,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}