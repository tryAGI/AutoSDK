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
    [global::System.Runtime.Serialization.DataContract]
    public enum FileType
    {
        /// <summary>
        /// text
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_TEXT")]
        Text,
        /// <summary>
        /// PDF
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PDF")]
        Pdf,
        /// <summary>
        /// MARKDOWN
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_MARKDOWN")]
        Markdown,
        /// <summary>
        /// PNG(not supported yet)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PNG")]
        Png,
        /// <summary>
        /// JPEG(not supported yet)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_JPEG")]
        Jpeg,
        /// <summary>
        /// JPG(not supported yet)
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_JPG")]
        Jpg,
        /// <summary>
        /// HTML
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_HTML")]
        Html,
        /// <summary>
        /// DOCX
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_DOCX")]
        Docx,
        /// <summary>
        /// DOCX
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_DOC")]
        Doc,
        /// <summary>
        /// PPT
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PPT")]
        Ppt,
        /// <summary>
        /// PPTX
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PPTX")]
        Pptx,
        /// <summary>
        /// XLS
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_XLS")]
        Xls,
        /// <summary>
        /// XLSX
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_XLSX")]
        Xlsx,
        /// <summary>
        /// CSV
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_CSV")]
        Csv,
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
                FileType.Text => "FILE_TYPE_TEXT",
                FileType.Pdf => "FILE_TYPE_PDF",
                FileType.Markdown => "FILE_TYPE_MARKDOWN",
                FileType.Png => "FILE_TYPE_PNG",
                FileType.Jpeg => "FILE_TYPE_JPEG",
                FileType.Jpg => "FILE_TYPE_JPG",
                FileType.Html => "FILE_TYPE_HTML",
                FileType.Docx => "FILE_TYPE_DOCX",
                FileType.Doc => "FILE_TYPE_DOC",
                FileType.Ppt => "FILE_TYPE_PPT",
                FileType.Pptx => "FILE_TYPE_PPTX",
                FileType.Xls => "FILE_TYPE_XLS",
                FileType.Xlsx => "FILE_TYPE_XLSX",
                FileType.Csv => "FILE_TYPE_CSV",
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
                "FILE_TYPE_TEXT" => FileType.Text,
                "FILE_TYPE_PDF" => FileType.Pdf,
                "FILE_TYPE_MARKDOWN" => FileType.Markdown,
                "FILE_TYPE_PNG" => FileType.Png,
                "FILE_TYPE_JPEG" => FileType.Jpeg,
                "FILE_TYPE_JPG" => FileType.Jpg,
                "FILE_TYPE_HTML" => FileType.Html,
                "FILE_TYPE_DOCX" => FileType.Docx,
                "FILE_TYPE_DOC" => FileType.Doc,
                "FILE_TYPE_PPT" => FileType.Ppt,
                "FILE_TYPE_PPTX" => FileType.Pptx,
                "FILE_TYPE_XLS" => FileType.Xls,
                "FILE_TYPE_XLSX" => FileType.Xlsx,
                "FILE_TYPE_CSV" => FileType.Csv,
                _ => null,
            };
        }
    }
}