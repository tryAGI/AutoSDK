//HintName: G.Models.UrlCitationBodyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of the URL citation. Always `url_citation`.<br/>
    /// Default Value: url_citation
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UrlCitationBodyType
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
    public static class UrlCitationBodyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UrlCitationBodyType value)
        {
            return value switch
            {
                UrlCitationBodyType.UrlCitation => "url_citation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UrlCitationBodyType? ToEnum(string value)
        {
            return value switch
            {
                "url_citation" => UrlCitationBodyType.UrlCitation,
                _ => null,
            };
        }
    }
}