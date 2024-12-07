//HintName: G.Models.BetaBase64PDFSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaBase64PDFSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        ApplicationPdf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBase64PDFSourceMediaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBase64PDFSourceMediaType value)
        {
            return value switch
            {
                BetaBase64PDFSourceMediaType.ApplicationPdf => "application/pdf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBase64PDFSourceMediaType? ToEnum(string value)
        {
            return value switch
            {
                "application/pdf" => BetaBase64PDFSourceMediaType.ApplicationPdf,
                _ => null,
            };
        }
    }
}