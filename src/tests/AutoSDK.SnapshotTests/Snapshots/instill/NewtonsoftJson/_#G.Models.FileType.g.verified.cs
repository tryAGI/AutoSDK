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
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_TEXT")]
        FILETYPETEXT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PDF")]
        FILETYPEPDF,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_MARKDOWN")]
        FILETYPEMARKDOWN,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PNG")]
        FILETYPEPNG,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_JPEG")]
        FILETYPEJPEG,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_JPG")]
        FILETYPEJPG,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_HTML")]
        FILETYPEHTML,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_DOCX")]
        FILETYPEDOCX,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_DOC")]
        FILETYPEDOC,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PPT")]
        FILETYPEPPT,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_PPTX")]
        FILETYPEPPTX,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_XLS")]
        FILETYPEXLS,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_XLSX")]
        FILETYPEXLSX,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FILE_TYPE_CSV")]
        FILETYPECSV,
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
                FileType.FILETYPETEXT => "FILE_TYPE_TEXT",
                FileType.FILETYPEPDF => "FILE_TYPE_PDF",
                FileType.FILETYPEMARKDOWN => "FILE_TYPE_MARKDOWN",
                FileType.FILETYPEPNG => "FILE_TYPE_PNG",
                FileType.FILETYPEJPEG => "FILE_TYPE_JPEG",
                FileType.FILETYPEJPG => "FILE_TYPE_JPG",
                FileType.FILETYPEHTML => "FILE_TYPE_HTML",
                FileType.FILETYPEDOCX => "FILE_TYPE_DOCX",
                FileType.FILETYPEDOC => "FILE_TYPE_DOC",
                FileType.FILETYPEPPT => "FILE_TYPE_PPT",
                FileType.FILETYPEPPTX => "FILE_TYPE_PPTX",
                FileType.FILETYPEXLS => "FILE_TYPE_XLS",
                FileType.FILETYPEXLSX => "FILE_TYPE_XLSX",
                FileType.FILETYPECSV => "FILE_TYPE_CSV",
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
                "FILE_TYPE_TEXT" => FileType.FILETYPETEXT,
                "FILE_TYPE_PDF" => FileType.FILETYPEPDF,
                "FILE_TYPE_MARKDOWN" => FileType.FILETYPEMARKDOWN,
                "FILE_TYPE_PNG" => FileType.FILETYPEPNG,
                "FILE_TYPE_JPEG" => FileType.FILETYPEJPEG,
                "FILE_TYPE_JPG" => FileType.FILETYPEJPG,
                "FILE_TYPE_HTML" => FileType.FILETYPEHTML,
                "FILE_TYPE_DOCX" => FileType.FILETYPEDOCX,
                "FILE_TYPE_DOC" => FileType.FILETYPEDOC,
                "FILE_TYPE_PPT" => FileType.FILETYPEPPT,
                "FILE_TYPE_PPTX" => FileType.FILETYPEPPTX,
                "FILE_TYPE_XLS" => FileType.FILETYPEXLS,
                "FILE_TYPE_XLSX" => FileType.FILETYPEXLSX,
                "FILE_TYPE_CSV" => FileType.FILETYPECSV,
                _ => null,
            };
        }
    }
}