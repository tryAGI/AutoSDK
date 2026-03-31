//HintName: G.Models.UpdateAuthSecretRequestDtoBasicAuthenticationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateAuthSecretRequestDtoBasicAuthenticationType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateAuthSecretRequestDtoBasicAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAuthSecretRequestDtoBasicAuthenticationType value)
        {
            return value switch
            {
                UpdateAuthSecretRequestDtoBasicAuthenticationType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAuthSecretRequestDtoBasicAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => UpdateAuthSecretRequestDtoBasicAuthenticationType.Basic,
                _ => null,
            };
        }
    }
}