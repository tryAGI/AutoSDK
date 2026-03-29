//HintName: G.Models.ScrapeOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScrapeOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Branding,
        /// <summary>
        /// 
        /// </summary>
        ChangeTracking,
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
    public static class ScrapeOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsFormat value)
        {
            return value switch
            {
                ScrapeOptionsFormat.Branding => "branding",
                ScrapeOptionsFormat.ChangeTracking => "changeTracking",
                ScrapeOptionsFormat.Html => "html",
                ScrapeOptionsFormat.Json => "json",
                ScrapeOptionsFormat.Links => "links",
                ScrapeOptionsFormat.Markdown => "markdown",
                ScrapeOptionsFormat.RawHtml => "rawHtml",
                ScrapeOptionsFormat.Screenshot => "screenshot",
                ScrapeOptionsFormat.Screenshot_fullPage => "screenshot@fullPage",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "branding" => ScrapeOptionsFormat.Branding,
                "changeTracking" => ScrapeOptionsFormat.ChangeTracking,
                "html" => ScrapeOptionsFormat.Html,
                "json" => ScrapeOptionsFormat.Json,
                "links" => ScrapeOptionsFormat.Links,
                "markdown" => ScrapeOptionsFormat.Markdown,
                "rawHtml" => ScrapeOptionsFormat.RawHtml,
                "screenshot" => ScrapeOptionsFormat.Screenshot,
                "screenshot@fullPage" => ScrapeOptionsFormat.Screenshot_fullPage,
                _ => null,
            };
        }
    }
}