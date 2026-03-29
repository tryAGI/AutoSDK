//HintName: G.Models.DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of document (one of the seven currently supported file types)
    /// </summary>
    public enum DocumentType
    {
        /// <summary>
        /// 
        /// </summary>
        Csv,
        /// <summary>
        /// 
        /// </summary>
        Docx,
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Json,
        /// <summary>
        /// 
        /// </summary>
        Pdf,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Pptx,
        /// <summary>
        /// 
        /// </summary>
        Tsv,
        /// <summary>
        /// 
        /// </summary>
        Txt,
        /// <summary>
        /// 
        /// </summary>
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