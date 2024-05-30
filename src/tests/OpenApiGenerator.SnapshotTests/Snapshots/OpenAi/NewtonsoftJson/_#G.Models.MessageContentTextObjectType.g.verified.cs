//HintName: G.Models.MessageContentTextObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `text`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MessageContentTextObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    public static class MessageContentTextObjectTypeExtensions
    {
        public static string ToValueString(this MessageContentTextObjectType value)
        {
            return value switch
            {
                MessageContentTextObjectType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextObjectType ToEnum(string value)
        {
            return value switch
            {
                "text" => MessageContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageContentTextObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}