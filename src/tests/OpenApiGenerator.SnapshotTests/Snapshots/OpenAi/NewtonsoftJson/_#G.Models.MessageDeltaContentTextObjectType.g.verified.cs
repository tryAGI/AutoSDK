//HintName: G.Models.MessageDeltaContentTextObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `text`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageDeltaContentTextObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    public static class MessageDeltaContentTextObjectTypeExtensions
    {
        public static string ToValueString(this MessageDeltaContentTextObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextObjectType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextObjectType ToEnum(string value)
        {
            return value switch
            {
                "text" => MessageDeltaContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageDeltaContentTextObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageDeltaContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}