//HintName: G.Models.MarkdownRenderRequestMode.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The rendering mode.<br/>
    /// Default Value: markdown<br/>
    /// Example: markdown
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum MarkdownRenderRequestMode
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gfm")]
        Gfm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
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
                MarkdownRenderRequestMode.Gfm => "gfm",
                MarkdownRenderRequestMode.Markdown => "markdown",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MarkdownRenderRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "gfm" => MarkdownRenderRequestMode.Gfm,
                "markdown" => MarkdownRenderRequestMode.Markdown,
                _ => null,
            };
        }
    }
}