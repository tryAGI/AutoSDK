//HintName: G.Models.PublicKeyEncryptionPlanAlgorithm.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The encryption algorithm to use.
    /// </summary>
    public enum PublicKeyEncryptionPlanAlgorithm
    {
        /// <summary>
        /// 
        /// </summary>
        RsaOaep256,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicKeyEncryptionPlanAlgorithmExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicKeyEncryptionPlanAlgorithm value)
        {
            return value switch
            {
                PublicKeyEncryptionPlanAlgorithm.RsaOaep256 => "RSA-OAEP-256",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicKeyEncryptionPlanAlgorithm? ToEnum(string value)
        {
            return value switch
            {
                "RSA-OAEP-256" => PublicKeyEncryptionPlanAlgorithm.RsaOaep256,
                _ => null,
            };
        }
    }
}