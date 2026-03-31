//HintName: G.Models.CreateSecretOpenAIRequestDtoProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider type for OpenAI.
    /// </summary>
    public enum CreateSecretOpenAIRequestDtoProvider
    {
        /// <summary>
        /// 
        /// </summary>
        ExternalOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSecretOpenAIRequestDtoProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSecretOpenAIRequestDtoProvider value)
        {
            return value switch
            {
                CreateSecretOpenAIRequestDtoProvider.ExternalOpenai => "external-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSecretOpenAIRequestDtoProvider? ToEnum(string value)
        {
            return value switch
            {
                "external-openai" => CreateSecretOpenAIRequestDtoProvider.ExternalOpenai,
                _ => null,
            };
        }
    }
}