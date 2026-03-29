//HintName: G.Models.WorkflowAnthropicBedrockModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the model (`anthropic-bedrock`).
    /// </summary>
    public enum WorkflowAnthropicBedrockModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        AnthropicBedrock,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WorkflowAnthropicBedrockModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WorkflowAnthropicBedrockModelProvider value)
        {
            return value switch
            {
                WorkflowAnthropicBedrockModelProvider.AnthropicBedrock => "anthropic-bedrock",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WorkflowAnthropicBedrockModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic-bedrock" => WorkflowAnthropicBedrockModelProvider.AnthropicBedrock,
                _ => null,
            };
        }
    }
}