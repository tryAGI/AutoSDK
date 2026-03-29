//HintName: G.Models.ProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderType
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
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        ChatgptOauth,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        GoogleAi,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        HuggingFace,
        /// <summary>
        /// 
        /// </summary>
        Letta,
        /// <summary>
        /// 
        /// </summary>
        LmstudioOpenai,
        /// <summary>
        /// 
        /// </summary>
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
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
        Sglang,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Vllm,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Zai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderType value)
        {
            return value switch
            {
                ProviderType.Anthropic => "anthropic",
                ProviderType.Azure => "azure",
                ProviderType.Bedrock => "bedrock",
                ProviderType.Cerebras => "cerebras",
                ProviderType.ChatgptOauth => "chatgpt_oauth",
                ProviderType.Deepseek => "deepseek",
                ProviderType.GoogleAi => "google_ai",
                ProviderType.GoogleVertex => "google_vertex",
                ProviderType.Groq => "groq",
                ProviderType.HuggingFace => "hugging-face",
                ProviderType.Letta => "letta",
                ProviderType.LmstudioOpenai => "lmstudio_openai",
                ProviderType.Minimax => "minimax",
                ProviderType.Mistral => "mistral",
                ProviderType.Ollama => "ollama",
                ProviderType.Openai => "openai",
                ProviderType.Openrouter => "openrouter",
                ProviderType.Sglang => "sglang",
                ProviderType.Together => "together",
                ProviderType.Vllm => "vllm",
                ProviderType.Xai => "xai",
                ProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ProviderType.Anthropic,
                "azure" => ProviderType.Azure,
                "bedrock" => ProviderType.Bedrock,
                "cerebras" => ProviderType.Cerebras,
                "chatgpt_oauth" => ProviderType.ChatgptOauth,
                "deepseek" => ProviderType.Deepseek,
                "google_ai" => ProviderType.GoogleAi,
                "google_vertex" => ProviderType.GoogleVertex,
                "groq" => ProviderType.Groq,
                "hugging-face" => ProviderType.HuggingFace,
                "letta" => ProviderType.Letta,
                "lmstudio_openai" => ProviderType.LmstudioOpenai,
                "minimax" => ProviderType.Minimax,
                "mistral" => ProviderType.Mistral,
                "ollama" => ProviderType.Ollama,
                "openai" => ProviderType.Openai,
                "openrouter" => ProviderType.Openrouter,
                "sglang" => ProviderType.Sglang,
                "together" => ProviderType.Together,
                "vllm" => ProviderType.Vllm,
                "xai" => ProviderType.Xai,
                "zai" => ProviderType.Zai,
                _ => null,
            };
        }
    }
}