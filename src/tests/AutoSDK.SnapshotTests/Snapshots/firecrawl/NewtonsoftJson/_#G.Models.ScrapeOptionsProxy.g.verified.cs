//HintName: G.Models.ScrapeOptionsProxy.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Specifies the type of proxy to use.<br/>
    ///  - **basic**: Proxies for scraping sites with none to basic anti-bot solutions. Fast and usually works.<br/>
    ///  - **enhanced**: Enhanced proxies for scraping sites with advanced anti-bot solutions. Slower, but more reliable on certain sites. Costs up to 5 credits per request.<br/>
    ///  - **auto**: Firecrawl will automatically retry scraping with enhanced proxies if the basic proxy fails. If the retry with enhanced is successful, 5 credits will be billed for the scrape. If the first attempt with basic is successful, only the regular cost will be billed.<br/>
    /// If you do not specify a proxy, Firecrawl will default to basic.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeOptionsProxy
    {
        /// <summary>
        /// Firecrawl will automatically retry scraping with enhanced proxies if the basic proxy fails. If the retry with enhanced is successful, 5 credits will be billed for the scrape. If the first attempt with basic is successful, only the regular cost will be billed.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="auto")]
        Auto,
        /// <summary>
        /// Proxies for scraping sites with none to basic anti-bot solutions. Fast and usually works.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="basic")]
        Basic,
        /// <summary>
        /// Enhanced proxies for scraping sites with advanced anti-bot solutions. Slower, but more reliable on certain sites. Costs up to 5 credits per request.
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="enhanced")]
        Enhanced,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScrapeOptionsProxyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScrapeOptionsProxy value)
        {
            return value switch
            {
                ScrapeOptionsProxy.Auto => "auto",
                ScrapeOptionsProxy.Basic => "basic",
                ScrapeOptionsProxy.Enhanced => "enhanced",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScrapeOptionsProxy? ToEnum(string value)
        {
            return value switch
            {
                "auto" => ScrapeOptionsProxy.Auto,
                "basic" => ScrapeOptionsProxy.Basic,
                "enhanced" => ScrapeOptionsProxy.Enhanced,
                _ => null,
            };
        }
    }
}