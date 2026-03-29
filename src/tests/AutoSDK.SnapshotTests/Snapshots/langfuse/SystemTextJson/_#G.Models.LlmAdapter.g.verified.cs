//HintName: G.Models.LlmAdapter.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum LlmAdapter
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        GoogleAiStudio,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertexAi,
        /// <summary>
        /// 
        /// </summary>
        Openai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LlmAdapterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LlmAdapter value)
        {
            return value switch
            {
                LlmAdapter.Anthropic => "anthropic",
                LlmAdapter.Azure => "azure",
                LlmAdapter.Bedrock => "bedrock",
                LlmAdapter.GoogleAiStudio => "google-ai-studio",
                LlmAdapter.GoogleVertexAi => "google-vertex-ai",
                LlmAdapter.Openai => "openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LlmAdapter? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LlmAdapter.Anthropic,
                "azure" => LlmAdapter.Azure,
                "bedrock" => LlmAdapter.Bedrock,
                "google-ai-studio" => LlmAdapter.GoogleAiStudio,
                "google-vertex-ai" => LlmAdapter.GoogleVertexAi,
                "openai" => LlmAdapter.Openai,
                _ => null,
            };
        }
    }
}