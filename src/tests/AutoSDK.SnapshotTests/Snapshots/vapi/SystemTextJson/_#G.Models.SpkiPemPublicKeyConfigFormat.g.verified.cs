//HintName: G.Models.SpkiPemPublicKeyConfigFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The format of the public key.
    /// </summary>
    public enum SpkiPemPublicKeyConfigFormat
    {
        /// <summary>
        /// 
        /// </summary>
        SpkiPem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SpkiPemPublicKeyConfigFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SpkiPemPublicKeyConfigFormat value)
        {
            return value switch
            {
                SpkiPemPublicKeyConfigFormat.SpkiPem => "spki-pem",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SpkiPemPublicKeyConfigFormat? ToEnum(string value)
        {
            return value switch
            {
                "spki-pem" => SpkiPemPublicKeyConfigFormat.SpkiPem,
                _ => null,
            };
        }
    }
}