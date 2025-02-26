//HintName: G.Models.Base64PDFSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Base64PDFSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Base64PDFSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Base64PDFSourceMediaType value)
        {
            return value switch
            {
                Base64PDFSourceMediaType.ApplicationPdf => "application/pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Base64PDFSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => Base64PDFSourceMediaType.ApplicationPdf,
                _ => null,
            };
        }
    }
}