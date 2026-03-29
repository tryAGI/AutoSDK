//HintName: G.Models.SearchAndScrapeRequestScrapeOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum SearchAndScrapeRequestScrapeOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branding")]
        Branding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="links")]
        Links,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="rawHtml")]
        RawHtml,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot")]
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="screenshot@fullPage")]
        Screenshot_fullPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SearchAndScrapeRequestScrapeOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SearchAndScrapeRequestScrapeOptionsFormat value)
        {
            return value switch
            {
                SearchAndScrapeRequestScrapeOptionsFormat.Branding => "branding",
                SearchAndScrapeRequestScrapeOptionsFormat.Html => "html",
                SearchAndScrapeRequestScrapeOptionsFormat.Json => "json",
                SearchAndScrapeRequestScrapeOptionsFormat.Links => "links",
                SearchAndScrapeRequestScrapeOptionsFormat.Markdown => "markdown",
                SearchAndScrapeRequestScrapeOptionsFormat.RawHtml => "rawHtml",
                SearchAndScrapeRequestScrapeOptionsFormat.Screenshot => "screenshot",
                SearchAndScrapeRequestScrapeOptionsFormat.Screenshot_fullPage => "screenshot@fullPage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SearchAndScrapeRequestScrapeOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "branding" => SearchAndScrapeRequestScrapeOptionsFormat.Branding,
                "html" => SearchAndScrapeRequestScrapeOptionsFormat.Html,
                "json" => SearchAndScrapeRequestScrapeOptionsFormat.Json,
                "links" => SearchAndScrapeRequestScrapeOptionsFormat.Links,
                "markdown" => SearchAndScrapeRequestScrapeOptionsFormat.Markdown,
                "rawHtml" => SearchAndScrapeRequestScrapeOptionsFormat.RawHtml,
                "screenshot" => SearchAndScrapeRequestScrapeOptionsFormat.Screenshot,
                "screenshot@fullPage" => SearchAndScrapeRequestScrapeOptionsFormat.Screenshot_fullPage,
                _ => null,
            };
        }
    }
}