//HintName: G.Models.DocxExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocxExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Docx,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocxExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocxExportOptionsFormat value)
        {
            return value switch
            {
                DocxExportOptionsFormat.Docx => "docx",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocxExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "docx" => DocxExportOptionsFormat.Docx,
                _ => null,
            };
        }
    }
}