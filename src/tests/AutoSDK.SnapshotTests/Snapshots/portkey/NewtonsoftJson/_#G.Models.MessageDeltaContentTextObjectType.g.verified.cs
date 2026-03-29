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

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageDeltaContentTextObjectTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageDeltaContentTextObjectType value)
        {
            return value switch
            {
                MessageDeltaContentTextObjectType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageDeltaContentTextObjectType? ToEnum(string value)
        {
            return value switch
            {
                "text" => MessageDeltaContentTextObjectType.Text,
                _ => null,
            };
        }
    }
}