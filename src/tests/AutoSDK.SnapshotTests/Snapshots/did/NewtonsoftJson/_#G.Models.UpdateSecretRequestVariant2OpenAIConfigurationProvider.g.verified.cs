//HintName: G.Models.UpdateSecretRequestVariant2OpenAIConfigurationProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for OpenAI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretRequestVariant2OpenAIConfigurationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="external-openai")]
        ExternalOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateSecretRequestVariant2OpenAIConfigurationProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretRequestVariant2OpenAIConfigurationProvider value)
        {
            return value switch
            {
                UpdateSecretRequestVariant2OpenAIConfigurationProvider.ExternalOpenai => "external-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretRequestVariant2OpenAIConfigurationProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-openai" => UpdateSecretRequestVariant2OpenAIConfigurationProvider.ExternalOpenai,
                _ => null,
            };
        }
    }
}