//HintName: G.Models.UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    public enum UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType
    {
        /// <summary>
        /// 
        /// </summary>
        Basic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType value)
        {
            return value switch
            {
                UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType.Basic => "basic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType? ToEnum(string value)
        {
            return value switch
            {
                "basic" => UpdateSecretRequestUpdateSecretRequest1BasicAuthenticationType.Basic,
                _ => null,
            };
        }
    }
}