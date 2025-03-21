//HintName: G.Models.ChatCompletionResponseMessageAnnotationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ChatCompletionResponseMessageAnnotationType
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
    public static class ChatCompletionResponseMessageAnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatCompletionResponseMessageAnnotationType value)
        {
            return value switch
            {
                ChatCompletionResponseMessageAnnotationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatCompletionResponseMessageAnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => ChatCompletionResponseMessageAnnotationType.UrlCitation,
                _ => null,
            };
        }
    }
}