//HintName: G.Models.ResponseFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ResponseFormat
    {
        /// <summary>
        /// 
        /// </summary>
        DeepseekocrMarkdown,
        /// <summary>
        /// 
        /// </summary>
        Doctags,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Otsl,
        /// <summary>
        /// 
        /// </summary>
        Plaintext,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormat value)
        {
            return value switch
            {
                ResponseFormat.DeepseekocrMarkdown => "deepseekocr_markdown",
                ResponseFormat.Doctags => "doctags",
                ResponseFormat.Html => "html",
                ResponseFormat.Markdown => "markdown",
                ResponseFormat.Otsl => "otsl",
                ResponseFormat.Plaintext => "plaintext",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormat? ToEnum(string value)
        {
            return value switch
            {
                "deepseekocr_markdown" => ResponseFormat.DeepseekocrMarkdown,
                "doctags" => ResponseFormat.Doctags,
                "html" => ResponseFormat.Html,
                "markdown" => ResponseFormat.Markdown,
                "otsl" => ResponseFormat.Otsl,
                "plaintext" => ResponseFormat.Plaintext,
                _ => null,
            };
        }
    }
}