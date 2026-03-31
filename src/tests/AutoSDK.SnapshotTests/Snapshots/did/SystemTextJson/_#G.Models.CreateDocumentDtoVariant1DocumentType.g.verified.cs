//HintName: G.Models.CreateDocumentDtoVariant1DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    public enum CreateDocumentDtoVariant1DocumentType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDocumentDtoVariant1DocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentDtoVariant1DocumentType value)
        {
            return value switch
            {
                CreateDocumentDtoVariant1DocumentType.Pdf => "pdf",
                CreateDocumentDtoVariant1DocumentType.Powerpoint => "powerpoint",
                CreateDocumentDtoVariant1DocumentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentDtoVariant1DocumentType? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => CreateDocumentDtoVariant1DocumentType.Pdf,
                "powerpoint" => CreateDocumentDtoVariant1DocumentType.Powerpoint,
                "text" => CreateDocumentDtoVariant1DocumentType.Text,
                _ => null,
            };
        }
    }
}