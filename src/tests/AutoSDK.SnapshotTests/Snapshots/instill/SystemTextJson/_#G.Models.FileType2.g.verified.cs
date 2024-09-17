//HintName: G.Models.FileType2.g.cs

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
    public enum FileType2
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
    public static class FileType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FileType2 value)
        {
            return value switch
            {
                FileType2.FILETYPETEXT => "FILE_TYPE_TEXT",
                FileType2.FILETYPEPDF => "FILE_TYPE_PDF",
                FileType2.FILETYPEMARKDOWN => "FILE_TYPE_MARKDOWN",
                FileType2.FILETYPEPNG => "FILE_TYPE_PNG",
                FileType2.FILETYPEJPEG => "FILE_TYPE_JPEG",
                FileType2.FILETYPEJPG => "FILE_TYPE_JPG",
                FileType2.FILETYPEHTML => "FILE_TYPE_HTML",
                FileType2.FILETYPEDOCX => "FILE_TYPE_DOCX",
                FileType2.FILETYPEDOC => "FILE_TYPE_DOC",
                FileType2.FILETYPEPPT => "FILE_TYPE_PPT",
                FileType2.FILETYPEPPTX => "FILE_TYPE_PPTX",
                FileType2.FILETYPEXLS => "FILE_TYPE_XLS",
                FileType2.FILETYPEXLSX => "FILE_TYPE_XLSX",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FileType2? ToEnum(string value)
        {
            return value switch
            {
                "FILE_TYPE_TEXT" => FileType2.FILETYPETEXT,
                "FILE_TYPE_PDF" => FileType2.FILETYPEPDF,
                "FILE_TYPE_MARKDOWN" => FileType2.FILETYPEMARKDOWN,
                "FILE_TYPE_PNG" => FileType2.FILETYPEPNG,
                "FILE_TYPE_JPEG" => FileType2.FILETYPEJPEG,
                "FILE_TYPE_JPG" => FileType2.FILETYPEJPG,
                "FILE_TYPE_HTML" => FileType2.FILETYPEHTML,
                "FILE_TYPE_DOCX" => FileType2.FILETYPEDOCX,
                "FILE_TYPE_DOC" => FileType2.FILETYPEDOC,
                "FILE_TYPE_PPT" => FileType2.FILETYPEPPT,
                "FILE_TYPE_PPTX" => FileType2.FILETYPEPPTX,
                "FILE_TYPE_XLS" => FileType2.FILETYPEXLS,
                "FILE_TYPE_XLSX" => FileType2.FILETYPEXLSX,
                _ => null,
            };
        }
    }
}