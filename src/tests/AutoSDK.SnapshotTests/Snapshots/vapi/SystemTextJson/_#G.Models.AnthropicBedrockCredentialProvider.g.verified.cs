//HintName: G.Models.AnthropicBedrockCredentialProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AnthropicBedrockCredentialProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBedrockCredentialProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBedrockCredentialProvider value)
        {
            return value switch
            {
                AnthropicBedrockCredentialProvider.AnthropicBedrock => "anthropic-bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBedrockCredentialProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-bedrock" => AnthropicBedrockCredentialProvider.AnthropicBedrock,
                _ => null,
            };
        }
    }
}