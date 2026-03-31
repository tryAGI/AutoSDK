//HintName: G.Models.ILogicalDocumentDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    public enum ILogicalDocumentDocumentType
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
    public static class ILogicalDocumentDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ILogicalDocumentDocumentType value)
        {
            return value switch
            {
                ILogicalDocumentDocumentType.Archive => "archive",
                ILogicalDocumentDocumentType.Audio => "audio",
                ILogicalDocumentDocumentType.Csv => "csv",
                ILogicalDocumentDocumentType.Excel => "excel",
                ILogicalDocumentDocumentType.Html => "html",
                ILogicalDocumentDocumentType.Image => "image",
                ILogicalDocumentDocumentType.Json => "json",
                ILogicalDocumentDocumentType.Markdown => "markdown",
                ILogicalDocumentDocumentType.Pdf => "pdf",
                ILogicalDocumentDocumentType.Powerpoint => "powerpoint",
                ILogicalDocumentDocumentType.Text => "text",
                ILogicalDocumentDocumentType.Video => "video",
                ILogicalDocumentDocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ILogicalDocumentDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => ILogicalDocumentDocumentType.Archive,
                "audio" => ILogicalDocumentDocumentType.Audio,
                "csv" => ILogicalDocumentDocumentType.Csv,
                "excel" => ILogicalDocumentDocumentType.Excel,
                "html" => ILogicalDocumentDocumentType.Html,
                "image" => ILogicalDocumentDocumentType.Image,
                "json" => ILogicalDocumentDocumentType.Json,
                "markdown" => ILogicalDocumentDocumentType.Markdown,
                "pdf" => ILogicalDocumentDocumentType.Pdf,
                "powerpoint" => ILogicalDocumentDocumentType.Powerpoint,
                "text" => ILogicalDocumentDocumentType.Text,
                "video" => ILogicalDocumentDocumentType.Video,
                "word" => ILogicalDocumentDocumentType.Word,
                _ => null,
            };
        }
    }
}