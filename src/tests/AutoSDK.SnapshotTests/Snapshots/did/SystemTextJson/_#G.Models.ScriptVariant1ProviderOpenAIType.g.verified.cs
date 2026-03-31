//HintName: G.Models.ScriptVariant1ProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ScriptVariant1ProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScriptVariant1ProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScriptVariant1ProviderOpenAIType value)
        {
            return value switch
            {
                ScriptVariant1ProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScriptVariant1ProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ScriptVariant1ProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}