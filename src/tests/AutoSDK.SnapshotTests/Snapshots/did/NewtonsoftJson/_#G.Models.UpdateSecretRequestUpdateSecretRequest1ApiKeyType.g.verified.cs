//HintName: G.Models.UpdateSecretRequestUpdateSecretRequest1ApiKeyType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The authentication type.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretRequestUpdateSecretRequest1ApiKeyType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="api_key")]
        ApiKey,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretRequestUpdateSecretRequest1ApiKeyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretRequestUpdateSecretRequest1ApiKeyType value)
        {
            return value switch
            {
                UpdateSecretRequestUpdateSecretRequest1ApiKeyType.ApiKey => "api_key",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretRequestUpdateSecretRequest1ApiKeyType? ToEnum(string value)
        {
            return value switch
            {
                "api_key" => UpdateSecretRequestUpdateSecretRequest1ApiKeyType.ApiKey,
                _ => null,
            };
        }
    }
}