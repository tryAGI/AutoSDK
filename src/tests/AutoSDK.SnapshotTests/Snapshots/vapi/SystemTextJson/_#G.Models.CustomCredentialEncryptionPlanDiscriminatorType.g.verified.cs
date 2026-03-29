//HintName: G.Models.CustomCredentialEncryptionPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CustomCredentialEncryptionPlanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        PublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomCredentialEncryptionPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomCredentialEncryptionPlanDiscriminatorType value)
        {
            return value switch
            {
                CustomCredentialEncryptionPlanDiscriminatorType.PublicKey => "public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomCredentialEncryptionPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "public-key" => CustomCredentialEncryptionPlanDiscriminatorType.PublicKey,
                _ => null,
            };
        }
    }
}