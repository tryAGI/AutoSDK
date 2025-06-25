//HintName: G.Models.PdfExportOptionsFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PdfExportOptionsFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PdfExportOptionsFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PdfExportOptionsFormat value)
        {
            return value switch
            {
                PdfExportOptionsFormat.Pdf => "pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PdfExportOptionsFormat? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => PdfExportOptionsFormat.Pdf,
                _ => null,
            };
        }
    }
}