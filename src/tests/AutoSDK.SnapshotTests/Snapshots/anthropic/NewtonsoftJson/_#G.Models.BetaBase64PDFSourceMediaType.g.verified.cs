//HintName: G.Models.BetaBase64PDFSourceMediaType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaBase64PDFSourceMediaType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="application/pdf")]
        ApplicationDividepdf,
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
                BetaBase64PDFSourceMediaType.ApplicationDividepdf => "application/pdf",
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
                "application/pdf" => BetaBase64PDFSourceMediaType.ApplicationDividepdf,
                _ => null,
            };
        }
    }
}