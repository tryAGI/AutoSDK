//HintName: G.Models.CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateExpressiveRequestDtoScriptVariant1ProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType value)
        {
            return value switch
            {
                CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => CreateExpressiveRequestDtoScriptVariant1ProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}