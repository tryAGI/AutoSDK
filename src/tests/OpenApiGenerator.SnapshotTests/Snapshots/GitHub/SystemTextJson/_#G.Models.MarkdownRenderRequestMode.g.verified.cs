//HintName: G.Models.MarkdownRenderRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The rendering mode.
    /// <br/>Default Value: markdown
    /// <br/>Example: markdown
    /// </summary>
    public enum MarkdownRenderRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Gfm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MarkdownRenderRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MarkdownRenderRequestMode value)
        {
            return value switch
            {
                MarkdownRenderRequestMode.Markdown => "markdown",
                MarkdownRenderRequestMode.Gfm => "gfm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkdownRenderRequestMode ToEnum(string value)
        {
            return value switch
            {
                "markdown" => MarkdownRenderRequestMode.Markdown,
                "gfm" => MarkdownRenderRequestMode.Gfm,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}