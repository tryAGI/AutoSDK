//HintName: G.Models.FileType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// - FILE_TYPE_TEXT: text<br/>
    ///  - FILE_TYPE_PDF: PDF<br/>
    ///  - FILE_TYPE_MARKDOWN: MARKDOWN<br/>
    ///  - FILE_TYPE_PNG: PNG(not supported yet)<br/>
    ///  - FILE_TYPE_JPEG: JPEG(not supported yet)<br/>
    ///  - FILE_TYPE_JPG: JPG(not supported yet)<br/>
    ///  - FILE_TYPE_HTML: HTML<br/>
    ///  - FILE_TYPE_DOCX: DOCX<br/>
    ///  - FILE_TYPE_DOC: DOC<br/>
    ///  - FILE_TYPE_PPT: PPT<br/>
    ///  - FILE_TYPE_PPTX: PPTX<br/>
    ///  - FILE_TYPE_XLS: XLS<br/>
    ///  - FILE_TYPE_XLSX: XLSX<br/>
    ///  - FILE_TYPE_CSV: CSV
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// text
        /// </summary>
        TEXT,
        /// <summary>
        /// PDF
        /// </summary>
        PDF,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        MARKDOWN,
        /// <summary>
        /// PNG(not supported yet)
        /// </summary>
        PNG,
        /// <summary>
        /// JPEG(not supported yet)
        /// </summary>
        JPEG,
        /// <summary>
        /// JPG(not supported yet)
        /// </summary>
        JPG,
        /// <summary>
        /// HTML
        /// </summary>
        HTML,
        /// <summary>
        /// DOCX
        /// </summary>
        DOCX,
        /// <summary>
        /// DOCX
        /// </summary>
        DOC,
        /// <summary>
        /// PPT
        /// </summary>
        PPT,
        /// <summary>
        /// PPTX
        /// </summary>
        PPTX,
        /// <summary>
        /// XLS
        /// </summary>
        XLS,
        /// <summary>
        /// XLSX
        /// </summary>
        XLSX,
        /// <summary>
        /// CSV
        /// </summary>
        CSV,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FileTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileType value)
        {
            return value switch
            {
                FileType.TEXT => "FILE_TYPE_TEXT",
                FileType.PDF => "FILE_TYPE_PDF",
                FileType.MARKDOWN => "FILE_TYPE_MARKDOWN",
                FileType.PNG => "FILE_TYPE_PNG",
                FileType.JPEG => "FILE_TYPE_JPEG",
                FileType.JPG => "FILE_TYPE_JPG",
                FileType.HTML => "FILE_TYPE_HTML",
                FileType.DOCX => "FILE_TYPE_DOCX",
                FileType.DOC => "FILE_TYPE_DOC",
                FileType.PPT => "FILE_TYPE_PPT",
                FileType.PPTX => "FILE_TYPE_PPTX",
                FileType.XLS => "FILE_TYPE_XLS",
                FileType.XLSX => "FILE_TYPE_XLSX",
                FileType.CSV => "FILE_TYPE_CSV",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileType? ToEnum(string value)
        {
            return value switch
            {
                "FILE_TYPE_TEXT" => FileType.TEXT,
                "FILE_TYPE_PDF" => FileType.PDF,
                "FILE_TYPE_MARKDOWN" => FileType.MARKDOWN,
                "FILE_TYPE_PNG" => FileType.PNG,
                "FILE_TYPE_JPEG" => FileType.JPEG,
                "FILE_TYPE_JPG" => FileType.JPG,
                "FILE_TYPE_HTML" => FileType.HTML,
                "FILE_TYPE_DOCX" => FileType.DOCX,
                "FILE_TYPE_DOC" => FileType.DOC,
                "FILE_TYPE_PPT" => FileType.PPT,
                "FILE_TYPE_PPTX" => FileType.PPTX,
                "FILE_TYPE_XLS" => FileType.XLS,
                "FILE_TYPE_XLSX" => FileType.XLSX,
                "FILE_TYPE_CSV" => FileType.CSV,
                _ => null,
            };
        }
    }
}