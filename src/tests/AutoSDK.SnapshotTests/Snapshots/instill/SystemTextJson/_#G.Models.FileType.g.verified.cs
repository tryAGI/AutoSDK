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
    ///  - FILE_TYPE_XLS: XLS(not supported yet)<br/>
    ///  - FILE_TYPE_XLSX: XLSX
    /// </summary>
    public enum FileType
    {
        /// <summary>
        /// 
        /// </summary>
        FILETYPETEXT,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEPDF,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEMARKDOWN,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEPNG,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEJPEG,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEJPG,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEHTML,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEDOCX,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEDOC,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEPPT,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEPPTX,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEXLS,
        /// <summary>
        /// 
        /// </summary>
        FILETYPEXLSX,
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
                _ => null,
            };
        }
    }
}