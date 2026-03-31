//HintName: G.Models.CreateSecretAzureOpenAIRequestDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for Azure OpenAI.
    /// </summary>
    public enum CreateSecretAzureOpenAIRequestDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalAzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretAzureOpenAIRequestDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretAzureOpenAIRequestDtoProvider value)
        {
            return value switch
            {
                CreateSecretAzureOpenAIRequestDtoProvider.ExternalAzureOpenai => "external-azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretAzureOpenAIRequestDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-azure-openai" => CreateSecretAzureOpenAIRequestDtoProvider.ExternalAzureOpenai,
                _ => null,
            };
        }
    }
}