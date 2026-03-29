//HintName: G.Models.CreateSecretRequestDtoBearerTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateSecretRequestDtoBearerTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bearer")]
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretRequestDtoBearerTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestDtoBearerTokenType value)
        {
            return value switch
            {
                CreateSecretRequestDtoBearerTokenType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestDtoBearerTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => CreateSecretRequestDtoBearerTokenType.Bearer,
                _ => null,
            };
        }
    }
}