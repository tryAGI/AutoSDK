//HintName: G.Models.GetDocumentResponseDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetDocumentResponseDocumentType
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
    public static class GetDocumentResponseDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetDocumentResponseDocumentType value)
        {
            return value switch
            {
                GetDocumentResponseDocumentType.Archive => "archive",
                GetDocumentResponseDocumentType.Audio => "audio",
                GetDocumentResponseDocumentType.Csv => "csv",
                GetDocumentResponseDocumentType.Excel => "excel",
                GetDocumentResponseDocumentType.Html => "html",
                GetDocumentResponseDocumentType.Image => "image",
                GetDocumentResponseDocumentType.Json => "json",
                GetDocumentResponseDocumentType.Markdown => "markdown",
                GetDocumentResponseDocumentType.Pdf => "pdf",
                GetDocumentResponseDocumentType.Powerpoint => "powerpoint",
                GetDocumentResponseDocumentType.Text => "text",
                GetDocumentResponseDocumentType.Video => "video",
                GetDocumentResponseDocumentType.Word => "word",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetDocumentResponseDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "archive" => GetDocumentResponseDocumentType.Archive,
                "audio" => GetDocumentResponseDocumentType.Audio,
                "csv" => GetDocumentResponseDocumentType.Csv,
                "excel" => GetDocumentResponseDocumentType.Excel,
                "html" => GetDocumentResponseDocumentType.Html,
                "image" => GetDocumentResponseDocumentType.Image,
                "json" => GetDocumentResponseDocumentType.Json,
                "markdown" => GetDocumentResponseDocumentType.Markdown,
                "pdf" => GetDocumentResponseDocumentType.Pdf,
                "powerpoint" => GetDocumentResponseDocumentType.Powerpoint,
                "text" => GetDocumentResponseDocumentType.Text,
                "video" => GetDocumentResponseDocumentType.Video,
                "word" => GetDocumentResponseDocumentType.Word,
                _ => null,
            };
        }
    }
}