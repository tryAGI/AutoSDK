//HintName: G.Models.ILogicalDocumentDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ILogicalDocumentDocumentType
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