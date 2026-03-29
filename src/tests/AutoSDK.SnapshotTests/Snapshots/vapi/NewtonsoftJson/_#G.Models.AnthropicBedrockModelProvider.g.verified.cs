//HintName: G.Models.AnthropicBedrockModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The provider identifier for Anthropic via AWS Bedrock.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AnthropicBedrockModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic-bedrock")]
        AnthropicBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AnthropicBedrockModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AnthropicBedrockModelProvider value)
        {
            return value switch
            {
                AnthropicBedrockModelProvider.AnthropicBedrock => "anthropic-bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AnthropicBedrockModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-bedrock" => AnthropicBedrockModelProvider.AnthropicBedrock,
                _ => null,
            };
        }
    }
}