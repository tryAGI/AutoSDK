//HintName: G.Models.ExportOptionsDiscriminatorFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExportOptionsDiscriminatorFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Docx,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        SegmentedJson,
        /// <summary>
        /// 
        /// </summary>
        Srt,
        /// <summary>
        /// 
        /// </summary>
        Txt,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExportOptionsDiscriminatorFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExportOptionsDiscriminatorFormat value)
        {
            return value switch
            {
                ExportOptionsDiscriminatorFormat.Docx => "docx",
                ExportOptionsDiscriminatorFormat.Html => "html",
                ExportOptionsDiscriminatorFormat.Pdf => "pdf",
                ExportOptionsDiscriminatorFormat.SegmentedJson => "segmented_json",
                ExportOptionsDiscriminatorFormat.Srt => "srt",
                ExportOptionsDiscriminatorFormat.Txt => "txt",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExportOptionsDiscriminatorFormat? ToEnum(string value)
        {
            return value switch
            {
                "docx" => ExportOptionsDiscriminatorFormat.Docx,
                "html" => ExportOptionsDiscriminatorFormat.Html,
                "pdf" => ExportOptionsDiscriminatorFormat.Pdf,
                "segmented_json" => ExportOptionsDiscriminatorFormat.SegmentedJson,
                "srt" => ExportOptionsDiscriminatorFormat.Srt,
                "txt" => ExportOptionsDiscriminatorFormat.Txt,
                _ => null,
            };
        }
    }
}