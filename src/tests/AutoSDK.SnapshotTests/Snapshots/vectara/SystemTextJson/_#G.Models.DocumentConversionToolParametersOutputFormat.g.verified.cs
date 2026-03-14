//HintName: G.Models.DocumentConversionToolParametersOutputFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Output format for the converted document.<br/>
    /// Example: markdown
    /// </summary>
    public enum DocumentConversionToolParametersOutputFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        StructuredDocument,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentConversionToolParametersOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentConversionToolParametersOutputFormat value)
        {
            return value switch
            {
                DocumentConversionToolParametersOutputFormat.Markdown => "markdown",
                DocumentConversionToolParametersOutputFormat.StructuredDocument => "structured_document",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentConversionToolParametersOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "markdown" => DocumentConversionToolParametersOutputFormat.Markdown,
                "structured_document" => DocumentConversionToolParametersOutputFormat.StructuredDocument,
                _ => null,
            };
        }
    }
}