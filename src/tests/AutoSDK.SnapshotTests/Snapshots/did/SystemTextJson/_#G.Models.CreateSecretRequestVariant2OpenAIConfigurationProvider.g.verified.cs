//HintName: G.Models.CreateSecretRequestVariant2OpenAIConfigurationProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for OpenAI.
    /// </summary>
    public enum CreateSecretRequestVariant2OpenAIConfigurationProvider
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretRequestVariant2OpenAIConfigurationProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretRequestVariant2OpenAIConfigurationProvider value)
        {
            return value switch
            {
                CreateSecretRequestVariant2OpenAIConfigurationProvider.ExternalOpenai => "external-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretRequestVariant2OpenAIConfigurationProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-openai" => CreateSecretRequestVariant2OpenAIConfigurationProvider.ExternalOpenai,
                _ => null,
            };
        }
    }
}