//HintName: G.Models.CreateDocumentResponseDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDocumentResponseDocumentType
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
    public static class CreateDocumentResponseDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentResponseDocumentType value)
        {
            return value switch
            {
                CreateDocumentResponseDocumentType.Archive => "archive",
                CreateDocumentResponseDocumentType.Audio => "audio",
                CreateDocumentResponseDocumentType.Csv => "csv",
                CreateDocumentResponseDocumentType.Excel => "excel",
                CreateDocumentResponseDocumentType.Html => "html",
                CreateDocumentResponseDocumentType.Image => "image",
                CreateDocumentResponseDocumentType.Json => "json",
                CreateDocumentResponseDocumentType.Markdown => "markdown",
                CreateDocumentResponseDocumentType.Pdf => "pdf",
                CreateDocumentResponseDocumentType.Powerpoint => "powerpoint",
                CreateDocumentResponseDocumentType.Text => "text",
                CreateDocumentResponseDocumentType.Video => "video",
                CreateDocumentResponseDocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentResponseDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => CreateDocumentResponseDocumentType.Archive,
                "audio" => CreateDocumentResponseDocumentType.Audio,
                "csv" => CreateDocumentResponseDocumentType.Csv,
                "excel" => CreateDocumentResponseDocumentType.Excel,
                "html" => CreateDocumentResponseDocumentType.Html,
                "image" => CreateDocumentResponseDocumentType.Image,
                "json" => CreateDocumentResponseDocumentType.Json,
                "markdown" => CreateDocumentResponseDocumentType.Markdown,
                "pdf" => CreateDocumentResponseDocumentType.Pdf,
                "powerpoint" => CreateDocumentResponseDocumentType.Powerpoint,
                "text" => CreateDocumentResponseDocumentType.Text,
                "video" => CreateDocumentResponseDocumentType.Video,
                "word" => CreateDocumentResponseDocumentType.Word,
                _ => null,
            };
        }
    }
}