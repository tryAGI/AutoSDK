//HintName: G.Models.ScrapeOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ScrapeOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="branding")]
        Branding,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="changeTracking")]
        ChangeTracking,
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