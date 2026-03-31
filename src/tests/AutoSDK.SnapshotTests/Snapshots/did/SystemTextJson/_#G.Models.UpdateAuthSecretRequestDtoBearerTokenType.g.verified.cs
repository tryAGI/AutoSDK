//HintName: G.Models.UpdateAuthSecretRequestDtoBearerTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateAuthSecretRequestDtoBearerTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAuthSecretRequestDtoBearerTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthSecretRequestDtoBearerTokenType value)
        {
            return value switch
            {
                UpdateAuthSecretRequestDtoBearerTokenType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthSecretRequestDtoBearerTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => UpdateAuthSecretRequestDtoBearerTokenType.Bearer,
                _ => null,
            };
        }
    }
}