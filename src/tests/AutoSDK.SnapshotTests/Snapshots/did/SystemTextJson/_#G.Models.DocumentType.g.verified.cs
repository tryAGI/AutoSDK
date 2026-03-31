//HintName: G.Models.DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        Archive,
        /// <summary>
        /// 
        /// </summary>
        Audio,
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Excel,
        /// <summary>
        /// 
        /// </summary>
        Html,
        /// <summary>
        /// 
        /// </summary>
        Image,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Powerpoint,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Video,
        /// <summary>
        /// 
        /// </summary>
        Word,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentType value)
        {
            return value switch
            {
                DocumentType.Archive => "archive",
                DocumentType.Audio => "audio",
                DocumentType.Csv => "csv",
                DocumentType.Excel => "excel",
                DocumentType.Html => "html",
                DocumentType.Image => "image",
                DocumentType.Json => "json",
                DocumentType.Markdown => "markdown",
                DocumentType.Pdf => "pdf",
                DocumentType.Powerpoint => "powerpoint",
                DocumentType.Text => "text",
                DocumentType.Video => "video",
                DocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => DocumentType.Archive,
                "audio" => DocumentType.Audio,
                "csv" => DocumentType.Csv,
                "excel" => DocumentType.Excel,
                "html" => DocumentType.Html,
                "image" => DocumentType.Image,
                "json" => DocumentType.Json,
                "markdown" => DocumentType.Markdown,
                "pdf" => DocumentType.Pdf,
                "powerpoint" => DocumentType.Powerpoint,
                "text" => DocumentType.Text,
                "video" => DocumentType.Video,
                "word" => DocumentType.Word,
                _ => null,
            };
        }
    }
}