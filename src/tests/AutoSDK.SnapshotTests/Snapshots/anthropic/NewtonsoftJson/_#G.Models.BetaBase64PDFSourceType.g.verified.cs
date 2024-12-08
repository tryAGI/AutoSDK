//HintName: G.Models.BetaBase64PDFSourceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum BetaBase64PDFSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="base64")]
        Base64,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaBase64PDFSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaBase64PDFSourceType value)
        {
            return value switch
            {
                BetaBase64PDFSourceType.Base64 => "base64",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaBase64PDFSourceType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaBase64PDFSourceType.Base64,
                _ => null,
            };
        }
    }
}