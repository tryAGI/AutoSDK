//HintName: G.Models.ScrapeOptionsActionScrapeType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Scrape the current page content, returns the url and the html.
    /// </summary>
    public enum ScrapeOptionsActionScrapeType
    {
        /// <summary>
        /// 
        /// </summary>
        Scrape,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsActionScrapeTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsActionScrapeType value)
        {
            return value switch
            {
                ScrapeOptionsActionScrapeType.Scrape => "scrape",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsActionScrapeType? ToEnum(string value)
        {
            return value switch
            {
                "scrape" => ScrapeOptionsActionScrapeType.Scrape,
                _ => null,
            };
        }
    }
}