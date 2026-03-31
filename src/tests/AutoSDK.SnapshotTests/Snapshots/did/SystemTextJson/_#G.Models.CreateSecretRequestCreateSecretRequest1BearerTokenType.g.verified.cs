//HintName: G.Models.CreateSecretRequestCreateSecretRequest1BearerTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type for the secret.
    /// </summary>
    public enum CreateSecretRequestCreateSecretRequest1BearerTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretRequestCreateSecretRequest1BearerTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestCreateSecretRequest1BearerTokenType value)
        {
            return value switch
            {
                CreateSecretRequestCreateSecretRequest1BearerTokenType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestCreateSecretRequest1BearerTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => CreateSecretRequestCreateSecretRequest1BearerTokenType.Bearer,
                _ => null,
            };
        }
    }
}