//HintName: G.Models.ChatCompletionDocumentSourceTextType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies this document source as inline text.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionDocumentSourceTextType
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
    public static class ChatCompletionDocumentSourceTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDocumentSourceTextType value)
        {
            return value switch
            {
                ChatCompletionDocumentSourceTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDocumentSourceTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => ChatCompletionDocumentSourceTextType.Text,
                _ => null,
            };
        }
    }
}