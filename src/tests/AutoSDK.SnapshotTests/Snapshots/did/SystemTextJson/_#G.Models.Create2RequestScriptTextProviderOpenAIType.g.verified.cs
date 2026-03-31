//HintName: G.Models.Create2RequestScriptTextProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum Create2RequestScriptTextProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class Create2RequestScriptTextProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this Create2RequestScriptTextProviderOpenAIType value)
        {
            return value switch
            {
                Create2RequestScriptTextProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static Create2RequestScriptTextProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => Create2RequestScriptTextProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}