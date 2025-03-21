//HintName: G.Models.UrlCitationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.
    /// </summary>
    public enum UrlCitationType
    {
        /// <summary>
        /// 
        /// </summary>
        UrlCitation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UrlCitationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlCitationType value)
        {
            return value switch
            {
                UrlCitationType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlCitationType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => UrlCitationType.UrlCitation,
                _ => null,
            };
        }
    }
}