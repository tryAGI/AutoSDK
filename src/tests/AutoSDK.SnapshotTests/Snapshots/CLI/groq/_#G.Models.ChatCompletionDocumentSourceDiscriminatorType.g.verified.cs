//HintName: G.Models.ChatCompletionDocumentSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatCompletionDocumentSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionDocumentSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDocumentSourceDiscriminatorType value)
        {
            return value switch
            {
                ChatCompletionDocumentSourceDiscriminatorType.Json => "json",
                ChatCompletionDocumentSourceDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDocumentSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "json" => ChatCompletionDocumentSourceDiscriminatorType.Json,
                "text" => ChatCompletionDocumentSourceDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}