//HintName: G.Models.DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of document (one of the seven currently supported file types)
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="csv")]
        Csv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="docx")]
        Docx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="jpg")]
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="json")]
        Json,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pdf")]
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="png")]
        Png,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="pptx")]
        Pptx,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tsv")]
        Tsv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="txt")]
        Txt,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xlsx")]
        Xlsx,
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
                DocumentType.Csv => "csv",
                DocumentType.Docx => "docx",
                DocumentType.Jpg => "jpg",
                DocumentType.Json => "json",
                DocumentType.Pdf => "pdf",
                DocumentType.Png => "png",
                DocumentType.Pptx => "pptx",
                DocumentType.Tsv => "tsv",
                DocumentType.Txt => "txt",
                DocumentType.Xlsx => "xlsx",
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
                "csv" => DocumentType.Csv,
                "docx" => DocumentType.Docx,
                "jpg" => DocumentType.Jpg,
                "json" => DocumentType.Json,
                "pdf" => DocumentType.Pdf,
                "png" => DocumentType.Png,
                "pptx" => DocumentType.Pptx,
                "tsv" => DocumentType.Tsv,
                "txt" => DocumentType.Txt,
                "xlsx" => DocumentType.Xlsx,
                _ => null,
            };
        }
    }
}