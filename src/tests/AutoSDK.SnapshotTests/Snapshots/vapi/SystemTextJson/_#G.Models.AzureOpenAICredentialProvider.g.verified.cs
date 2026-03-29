//HintName: G.Models.AzureOpenAICredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AzureOpenAICredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AzureOpenAICredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AzureOpenAICredentialProvider value)
        {
            return value switch
            {
                AzureOpenAICredentialProvider.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AzureOpenAICredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AzureOpenAICredentialProvider.AzureOpenai,
                _ => null,
            };
        }
    }
}