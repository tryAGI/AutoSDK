//HintName: G.Models.SecretAuthTypeApiKey.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SecretAuthTypeApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SecretAuthTypeApiKeyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SecretAuthTypeApiKey value)
        {
            return value switch
            {
                SecretAuthTypeApiKey.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SecretAuthTypeApiKey? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => SecretAuthTypeApiKey.ApiKey,
                _ => null,
            };
        }
    }
}