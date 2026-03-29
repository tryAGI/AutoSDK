//HintName: G.Models.PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="spki-pem")]
        SpkiPem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicKeyEncryptionPlanPublicKeyDiscriminatorFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat value)
        {
            return value switch
            {
                PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat.SpkiPem => "spki-pem",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat? ToEnum(string value)
        {
            return value switch
            {
                "spki-pem" => PublicKeyEncryptionPlanPublicKeyDiscriminatorFormat.SpkiPem,
                _ => null,
            };
        }
    }
}