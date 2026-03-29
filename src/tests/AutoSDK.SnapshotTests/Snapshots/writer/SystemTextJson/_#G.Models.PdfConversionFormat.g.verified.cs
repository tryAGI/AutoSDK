//HintName: G.Models.PdfConversionFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format into which the PDF content should be converted.
    /// </summary>
    public enum PdfConversionFormat
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
    public static class PdfConversionFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfConversionFormat value)
        {
            return value switch
            {
                PdfConversionFormat.Markdown => "markdown",
                PdfConversionFormat.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfConversionFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => PdfConversionFormat.Markdown,
                "text" => PdfConversionFormat.Text,
                _ => null,
            };
        }
    }
}