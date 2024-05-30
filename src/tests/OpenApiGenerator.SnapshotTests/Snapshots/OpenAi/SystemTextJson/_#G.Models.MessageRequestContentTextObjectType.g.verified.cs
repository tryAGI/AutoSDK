//HintName: G.Models.MessageRequestContentTextObjectType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Always `text`.
    /// </summary>
    public enum MessageRequestContentTextObjectType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    public static class MessageRequestContentTextObjectTypeExtensions
    {
        public static string ToValueString(this MessageRequestContentTextObjectType value)
        {
            return value switch
            {
                MessageRequestContentTextObjectType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageRequestContentTextObjectType ToEnum(string value)
        {
            return value switch
            {
                "text" => MessageRequestContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static MessageRequestContentTextObjectType ToEnum(int value)
        {
            return value switch
            {
                0 => MessageRequestContentTextObjectType.Text,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}