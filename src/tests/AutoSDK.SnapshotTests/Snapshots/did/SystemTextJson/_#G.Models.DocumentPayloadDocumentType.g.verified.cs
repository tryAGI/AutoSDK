//HintName: G.Models.DocumentPayloadDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum DocumentPayloadDocumentType
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
    public static class DocumentPayloadDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DocumentPayloadDocumentType value)
        {
            return value switch
            {
                DocumentPayloadDocumentType.Archive => "archive",
                DocumentPayloadDocumentType.Audio => "audio",
                DocumentPayloadDocumentType.Csv => "csv",
                DocumentPayloadDocumentType.Excel => "excel",
                DocumentPayloadDocumentType.Html => "html",
                DocumentPayloadDocumentType.Image => "image",
                DocumentPayloadDocumentType.Json => "json",
                DocumentPayloadDocumentType.Markdown => "markdown",
                DocumentPayloadDocumentType.Pdf => "pdf",
                DocumentPayloadDocumentType.Powerpoint => "powerpoint",
                DocumentPayloadDocumentType.Text => "text",
                DocumentPayloadDocumentType.Video => "video",
                DocumentPayloadDocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DocumentPayloadDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => DocumentPayloadDocumentType.Archive,
                "audio" => DocumentPayloadDocumentType.Audio,
                "csv" => DocumentPayloadDocumentType.Csv,
                "excel" => DocumentPayloadDocumentType.Excel,
                "html" => DocumentPayloadDocumentType.Html,
                "image" => DocumentPayloadDocumentType.Image,
                "json" => DocumentPayloadDocumentType.Json,
                "markdown" => DocumentPayloadDocumentType.Markdown,
                "pdf" => DocumentPayloadDocumentType.Pdf,
                "powerpoint" => DocumentPayloadDocumentType.Powerpoint,
                "text" => DocumentPayloadDocumentType.Text,
                "video" => DocumentPayloadDocumentType.Video,
                "word" => DocumentPayloadDocumentType.Word,
                _ => null,
            };
        }
    }
}