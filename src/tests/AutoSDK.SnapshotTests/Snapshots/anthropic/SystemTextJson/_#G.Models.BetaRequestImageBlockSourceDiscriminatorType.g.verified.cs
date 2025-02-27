//HintName: G.Models.BetaRequestImageBlockSourceDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaRequestImageBlockSourceDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Base64,
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaRequestImageBlockSourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaRequestImageBlockSourceDiscriminatorType value)
        {
            return value switch
            {
                BetaRequestImageBlockSourceDiscriminatorType.Base64 => "base64",
                BetaRequestImageBlockSourceDiscriminatorType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaRequestImageBlockSourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "base64" => BetaRequestImageBlockSourceDiscriminatorType.Base64,
                "url" => BetaRequestImageBlockSourceDiscriminatorType.Url,
                _ => null,
            };
        }
    }
}