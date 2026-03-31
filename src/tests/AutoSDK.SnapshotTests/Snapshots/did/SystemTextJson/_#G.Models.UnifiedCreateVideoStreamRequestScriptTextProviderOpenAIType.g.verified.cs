//HintName: G.Models.UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UnifiedCreateVideoStreamRequestScriptTextProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType value)
        {
            return value switch
            {
                UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => UnifiedCreateVideoStreamRequestScriptTextProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}