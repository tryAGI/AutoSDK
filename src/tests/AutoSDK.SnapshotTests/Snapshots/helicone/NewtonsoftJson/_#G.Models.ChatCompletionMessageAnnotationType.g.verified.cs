//HintName: G.Models.ChatCompletionMessageAnnotationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionMessageAnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="url_citation")]
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatCompletionMessageAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionMessageAnnotationType value)
        {
            return value switch
            {
                ChatCompletionMessageAnnotationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionMessageAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => ChatCompletionMessageAnnotationType.UrlCitation,
                _ => null,
            };
        }
    }
}