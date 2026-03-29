//HintName: G.Models.ChatCompletionDocumentSourceJSONType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Identifies this document source as JSON data.
    /// </summary>
    public enum ChatCompletionDocumentSourceJSONType
    {
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionDocumentSourceJSONTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionDocumentSourceJSONType value)
        {
            return value switch
            {
                ChatCompletionDocumentSourceJSONType.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionDocumentSourceJSONType? ToEnum(string value)
        {
            return value switch
            {
                "json" => ChatCompletionDocumentSourceJSONType.Json,
                _ => null,
            };
        }
    }
}