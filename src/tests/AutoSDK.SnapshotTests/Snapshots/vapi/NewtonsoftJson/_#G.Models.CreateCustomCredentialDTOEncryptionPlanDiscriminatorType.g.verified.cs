//HintName: G.Models.CreateCustomCredentialDTOEncryptionPlanDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateCustomCredentialDTOEncryptionPlanDiscriminatorType
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
    public static class CreateCustomCredentialDTOEncryptionPlanDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateCustomCredentialDTOEncryptionPlanDiscriminatorType value)
        {
            return value switch
            {
                CreateCustomCredentialDTOEncryptionPlanDiscriminatorType.PublicKey => "public-key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateCustomCredentialDTOEncryptionPlanDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "public-key" => CreateCustomCredentialDTOEncryptionPlanDiscriminatorType.PublicKey,
                _ => null,
            };
        }
    }
}