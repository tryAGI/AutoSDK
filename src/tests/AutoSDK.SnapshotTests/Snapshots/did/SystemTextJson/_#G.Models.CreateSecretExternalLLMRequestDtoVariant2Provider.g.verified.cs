//HintName: G.Models.CreateSecretExternalLLMRequestDtoVariant2Provider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for Azure OpenAI.
    /// </summary>
    public enum CreateSecretExternalLLMRequestDtoVariant2Provider
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalAzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretExternalLLMRequestDtoVariant2ProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretExternalLLMRequestDtoVariant2Provider value)
        {
            return value switch
            {
                CreateSecretExternalLLMRequestDtoVariant2Provider.ExternalAzureOpenai => "external-azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretExternalLLMRequestDtoVariant2Provider? ToEnum(string value)
        {
            return value switch
            {
                "external-azure-openai" => CreateSecretExternalLLMRequestDtoVariant2Provider.ExternalAzureOpenai,
                _ => null,
            };
        }
    }
}