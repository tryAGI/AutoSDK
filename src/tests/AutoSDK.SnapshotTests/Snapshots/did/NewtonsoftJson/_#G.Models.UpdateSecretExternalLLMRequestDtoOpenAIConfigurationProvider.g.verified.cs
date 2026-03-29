//HintName: G.Models.UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for OpenAI
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider
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
    public static class UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider value)
        {
            return value switch
            {
                UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider.ExternalOpenai => "external-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-openai" => UpdateSecretExternalLLMRequestDtoOpenAIConfigurationProvider.ExternalOpenai,
                _ => null,
            };
        }
    }
}