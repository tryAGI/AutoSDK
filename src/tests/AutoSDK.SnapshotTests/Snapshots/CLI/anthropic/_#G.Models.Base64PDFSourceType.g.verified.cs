//HintName: G.Models.Base64PDFSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Base64PDFSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Base64PDFSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Base64PDFSourceType value)
        {
            return value switch
            {
                Base64PDFSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Base64PDFSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => Base64PDFSourceType.Base64,
                _ => null,
            };
        }
    }
}