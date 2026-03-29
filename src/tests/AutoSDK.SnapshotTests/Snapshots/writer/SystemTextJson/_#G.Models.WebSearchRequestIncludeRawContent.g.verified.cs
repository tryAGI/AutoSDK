//HintName: G.Models.WebSearchRequestIncludeRawContent.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchRequestIncludeRawContent
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchRequestIncludeRawContentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchRequestIncludeRawContent value)
        {
            return value switch
            {
                WebSearchRequestIncludeRawContent.Markdown => "markdown",
                WebSearchRequestIncludeRawContent.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchRequestIncludeRawContent? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => WebSearchRequestIncludeRawContent.Markdown,
                "text" => WebSearchRequestIncludeRawContent.Text,
                _ => null,
            };
        }
    }
}