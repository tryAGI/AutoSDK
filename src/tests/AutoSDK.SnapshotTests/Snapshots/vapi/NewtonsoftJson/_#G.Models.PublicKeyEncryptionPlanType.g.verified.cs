//HintName: G.Models.PublicKeyEncryptionPlanType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of encryption plan.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PublicKeyEncryptionPlanType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public-key")]
        PublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicKeyEncryptionPlanTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicKeyEncryptionPlanType value)
        {
            return value switch
            {
                PublicKeyEncryptionPlanType.PublicKey => "public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicKeyEncryptionPlanType? ToEnum(string value)
        {
            return value switch
            {
                "public-key" => PublicKeyEncryptionPlanType.PublicKey,
                _ => null,
            };
        }
    }
}