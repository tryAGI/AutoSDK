//HintName: G.Models.CreateCrawlRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
    /// Default Value: markdown
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCrawlRequestFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateCrawlRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCrawlRequestFormat value)
        {
            return value switch
            {
                CreateCrawlRequestFormat.Markdown => "markdown",
                CreateCrawlRequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCrawlRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => CreateCrawlRequestFormat.Markdown,
                "text" => CreateCrawlRequestFormat.Text,
                _ => null,
            };
        }
    }
}