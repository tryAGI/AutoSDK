//HintName: G.Models.UpdateSecretRequestUpdateSecretRequest1BearerTokenType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateSecretRequestUpdateSecretRequest1BearerTokenType
    {
        /// <summary>
        /// 
        /// </summary>
        Bearer,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretRequestUpdateSecretRequest1BearerTokenTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretRequestUpdateSecretRequest1BearerTokenType value)
        {
            return value switch
            {
                UpdateSecretRequestUpdateSecretRequest1BearerTokenType.Bearer => "bearer",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretRequestUpdateSecretRequest1BearerTokenType? ToEnum(string value)
        {
            return value switch
            {
                "bearer" => UpdateSecretRequestUpdateSecretRequest1BearerTokenType.Bearer,
                _ => null,
            };
        }
    }
}