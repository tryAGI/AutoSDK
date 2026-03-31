//HintName: G.Models.TextScript3ProviderOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum TextScript3ProviderOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextScript3ProviderOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextScript3ProviderOpenAIType value)
        {
            return value switch
            {
                TextScript3ProviderOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextScript3ProviderOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => TextScript3ProviderOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}