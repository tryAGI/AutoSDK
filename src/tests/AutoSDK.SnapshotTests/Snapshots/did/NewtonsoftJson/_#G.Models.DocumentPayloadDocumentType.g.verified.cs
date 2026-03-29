//HintName: G.Models.DocumentPayloadDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentPayloadDocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="archive")]
        Archive,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="audio")]
        Audio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csv")]
        Csv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="excel")]
        Excel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="html")]
        Html,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="image")]
        Image,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="markdown")]
        Markdown,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf")]
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="powerpoint")]
        Powerpoint,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="text")]
        Text,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="video")]
        Video,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="word")]
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