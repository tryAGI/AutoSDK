//HintName: G.Models.CreateExtractRequestFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the extracted web page content. `markdown` returns content in markdown format. `text` returns plain text and may increase latency.<br/>
    /// Default Value: markdown
    /// </summary>
    public enum CreateExtractRequestFormat
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
    public static class CreateExtractRequestFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExtractRequestFormat value)
        {
            return value switch
            {
                CreateExtractRequestFormat.Markdown => "markdown",
                CreateExtractRequestFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExtractRequestFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => CreateExtractRequestFormat.Markdown,
                "text" => CreateExtractRequestFormat.Text,
                _ => null,
            };
        }
    }
}