//HintName: G.Models.SupportedDocumentType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SupportedDocumentType
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
    public static class SupportedDocumentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SupportedDocumentType value)
        {
            return value switch
            {
                SupportedDocumentType.Pdf => "pdf",
                SupportedDocumentType.Powerpoint => "powerpoint",
                SupportedDocumentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SupportedDocumentType? ToEnum(string value)
        {
            return value switch
            {
                "pdf" => SupportedDocumentType.Pdf,
                "powerpoint" => SupportedDocumentType.Powerpoint,
                "text" => SupportedDocumentType.Text,
                _ => null,
            };
        }
    }
}