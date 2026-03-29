//HintName: G.Models.ResponseUrlCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the annotation. Always `url_citation`.
    /// </summary>
    public enum ResponseUrlCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseUrlCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseUrlCitationType value)
        {
            return value switch
            {
                ResponseUrlCitationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseUrlCitationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => ResponseUrlCitationType.UrlCitation,
                _ => null,
            };
        }
    }
}