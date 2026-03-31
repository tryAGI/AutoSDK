//HintName: G.Models.Create3RequestScriptVariant1ProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create3RequestScriptVariant1ProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create3RequestScriptVariant1ProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create3RequestScriptVariant1ProviderOpenAIType value)
        {
            return value switch
            {
                Create3RequestScriptVariant1ProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create3RequestScriptVariant1ProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => Create3RequestScriptVariant1ProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}