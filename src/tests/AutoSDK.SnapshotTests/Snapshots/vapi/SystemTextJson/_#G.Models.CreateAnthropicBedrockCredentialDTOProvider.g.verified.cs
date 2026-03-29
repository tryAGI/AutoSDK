//HintName: G.Models.CreateAnthropicBedrockCredentialDTOProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAnthropicBedrockCredentialDTOProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAnthropicBedrockCredentialDTOProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAnthropicBedrockCredentialDTOProvider value)
        {
            return value switch
            {
                CreateAnthropicBedrockCredentialDTOProvider.AnthropicBedrock => "anthropic-bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAnthropicBedrockCredentialDTOProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-bedrock" => CreateAnthropicBedrockCredentialDTOProvider.AnthropicBedrock,
                _ => null,
            };
        }
    }
}