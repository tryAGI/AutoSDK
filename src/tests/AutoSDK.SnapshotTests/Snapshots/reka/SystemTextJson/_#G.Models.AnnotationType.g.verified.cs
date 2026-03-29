//HintName: G.Models.AnnotationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The annotation type. Always "url_citation".
    /// </summary>
    public enum AnnotationType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnnotationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnnotationType value)
        {
            return value switch
            {
                AnnotationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnnotationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => AnnotationType.UrlCitation,
                _ => null,
            };
        }
    }
}