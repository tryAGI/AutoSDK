//HintName: G.Models.ProviderApiKeyWriteProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderApiKeyWriteProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        Ollama,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        OpikFree,
        /// <summary>
        /// 
        /// </summary>
        VertexAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderApiKeyWriteProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderApiKeyWriteProvider value)
        {
            return value switch
            {
                ProviderApiKeyWriteProvider.Anthropic => "anthropic",
                ProviderApiKeyWriteProvider.Bedrock => "bedrock",
                ProviderApiKeyWriteProvider.CustomLlm => "custom-llm",
                ProviderApiKeyWriteProvider.Gemini => "gemini",
                ProviderApiKeyWriteProvider.Ollama => "ollama",
                ProviderApiKeyWriteProvider.Openai => "openai",
                ProviderApiKeyWriteProvider.Openrouter => "openrouter",
                ProviderApiKeyWriteProvider.OpikFree => "opik-free",
                ProviderApiKeyWriteProvider.VertexAi => "vertex-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderApiKeyWriteProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ProviderApiKeyWriteProvider.Anthropic,
                "bedrock" => ProviderApiKeyWriteProvider.Bedrock,
                "custom-llm" => ProviderApiKeyWriteProvider.CustomLlm,
                "gemini" => ProviderApiKeyWriteProvider.Gemini,
                "ollama" => ProviderApiKeyWriteProvider.Ollama,
                "openai" => ProviderApiKeyWriteProvider.Openai,
                "openrouter" => ProviderApiKeyWriteProvider.Openrouter,
                "opik-free" => ProviderApiKeyWriteProvider.OpikFree,
                "vertex-ai" => ProviderApiKeyWriteProvider.VertexAi,
                _ => null,
            };
        }
    }
}