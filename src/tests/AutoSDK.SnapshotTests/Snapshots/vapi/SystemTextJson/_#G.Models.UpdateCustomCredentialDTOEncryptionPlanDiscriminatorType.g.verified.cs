//HintName: G.Models.UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        PublicKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateCustomCredentialDTOEncryptionPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType value)
        {
            return value switch
            {
                UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType.PublicKey => "public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "public-key" => UpdateCustomCredentialDTOEncryptionPlanDiscriminatorType.PublicKey,
                _ => null,
            };
        }
    }
}