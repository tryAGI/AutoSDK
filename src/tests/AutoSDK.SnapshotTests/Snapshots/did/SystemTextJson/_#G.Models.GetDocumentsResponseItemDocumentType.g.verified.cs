//HintName: G.Models.GetDocumentsResponseItemDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    public enum GetDocumentsResponseItemDocumentType
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
    public static class GetDocumentsResponseItemDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentsResponseItemDocumentType value)
        {
            return value switch
            {
                GetDocumentsResponseItemDocumentType.Archive => "archive",
                GetDocumentsResponseItemDocumentType.Audio => "audio",
                GetDocumentsResponseItemDocumentType.Csv => "csv",
                GetDocumentsResponseItemDocumentType.Excel => "excel",
                GetDocumentsResponseItemDocumentType.Html => "html",
                GetDocumentsResponseItemDocumentType.Image => "image",
                GetDocumentsResponseItemDocumentType.Json => "json",
                GetDocumentsResponseItemDocumentType.Markdown => "markdown",
                GetDocumentsResponseItemDocumentType.Pdf => "pdf",
                GetDocumentsResponseItemDocumentType.Powerpoint => "powerpoint",
                GetDocumentsResponseItemDocumentType.Text => "text",
                GetDocumentsResponseItemDocumentType.Video => "video",
                GetDocumentsResponseItemDocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentsResponseItemDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => GetDocumentsResponseItemDocumentType.Archive,
                "audio" => GetDocumentsResponseItemDocumentType.Audio,
                "csv" => GetDocumentsResponseItemDocumentType.Csv,
                "excel" => GetDocumentsResponseItemDocumentType.Excel,
                "html" => GetDocumentsResponseItemDocumentType.Html,
                "image" => GetDocumentsResponseItemDocumentType.Image,
                "json" => GetDocumentsResponseItemDocumentType.Json,
                "markdown" => GetDocumentsResponseItemDocumentType.Markdown,
                "pdf" => GetDocumentsResponseItemDocumentType.Pdf,
                "powerpoint" => GetDocumentsResponseItemDocumentType.Powerpoint,
                "text" => GetDocumentsResponseItemDocumentType.Text,
                "video" => GetDocumentsResponseItemDocumentType.Video,
                "word" => GetDocumentsResponseItemDocumentType.Word,
                _ => null,
            };
        }
    }
}