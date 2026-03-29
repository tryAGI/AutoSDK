//HintName: G.Models.SearchAndScrapeRequestScrapeOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SearchAndScrapeRequestScrapeOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Branding,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Links,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        RawHtml,
        /// <summary>
        /// 
        /// </summary>
        Screenshot,
        /// <summary>
        /// 
        /// </summary>
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