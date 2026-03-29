//HintName: G.Models.CreateDocumentRequestVariant1DocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// File format of the file
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateDocumentRequestVariant1DocumentType
    {
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateDocumentRequestVariant1DocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateDocumentRequestVariant1DocumentType value)
        {
            return value switch
            {
                CreateDocumentRequestVariant1DocumentType.Pdf => "pdf",
                CreateDocumentRequestVariant1DocumentType.Powerpoint => "powerpoint",
                CreateDocumentRequestVariant1DocumentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateDocumentRequestVariant1DocumentType? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => CreateDocumentRequestVariant1DocumentType.Pdf,
                "powerpoint" => CreateDocumentRequestVariant1DocumentType.Powerpoint,
                "text" => CreateDocumentRequestVariant1DocumentType.Text,
                _ => null,
            };
        }
    }
}