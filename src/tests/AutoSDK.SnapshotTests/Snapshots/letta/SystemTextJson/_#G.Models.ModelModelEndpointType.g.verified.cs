//HintName: G.Models.ModelModelEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: Use 'provider_type' field instead. The endpoint type for the model.
    /// </summary>
    public enum ModelModelEndpointType
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
        Koboldcpp,
        /// <summary>
        /// 
        /// </summary>
        Llamacpp,
        /// <summary>
        /// 
        /// </summary>
        Lmstudio,
        /// <summary>
        /// 
        /// </summary>
        LmstudioChatcompletions,
        /// <summary>
        /// 
        /// </summary>
        LmstudioLegacy,
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
        Together,
        /// <summary>
        /// 
        /// </summary>
        Vllm,
        /// <summary>
        /// 
        /// </summary>
        Webui,
        /// <summary>
        /// 
        /// </summary>
        WebuiLegacy,
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
    public static class ModelModelEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelModelEndpointType value)
        {
            return value switch
            {
                ModelModelEndpointType.Anthropic => "anthropic",
                ModelModelEndpointType.Azure => "azure",
                ModelModelEndpointType.Bedrock => "bedrock",
                ModelModelEndpointType.ChatgptOauth => "chatgpt_oauth",
                ModelModelEndpointType.Deepseek => "deepseek",
                ModelModelEndpointType.GoogleAi => "google_ai",
                ModelModelEndpointType.GoogleVertex => "google_vertex",
                ModelModelEndpointType.Groq => "groq",
                ModelModelEndpointType.HuggingFace => "hugging-face",
                ModelModelEndpointType.Koboldcpp => "koboldcpp",
                ModelModelEndpointType.Llamacpp => "llamacpp",
                ModelModelEndpointType.Lmstudio => "lmstudio",
                ModelModelEndpointType.LmstudioChatcompletions => "lmstudio-chatcompletions",
                ModelModelEndpointType.LmstudioLegacy => "lmstudio-legacy",
                ModelModelEndpointType.Minimax => "minimax",
                ModelModelEndpointType.Mistral => "mistral",
                ModelModelEndpointType.Ollama => "ollama",
                ModelModelEndpointType.Openai => "openai",
                ModelModelEndpointType.Openrouter => "openrouter",
                ModelModelEndpointType.Together => "together",
                ModelModelEndpointType.Vllm => "vllm",
                ModelModelEndpointType.Webui => "webui",
                ModelModelEndpointType.WebuiLegacy => "webui-legacy",
                ModelModelEndpointType.Xai => "xai",
                ModelModelEndpointType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelModelEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ModelModelEndpointType.Anthropic,
                "azure" => ModelModelEndpointType.Azure,
                "bedrock" => ModelModelEndpointType.Bedrock,
                "chatgpt_oauth" => ModelModelEndpointType.ChatgptOauth,
                "deepseek" => ModelModelEndpointType.Deepseek,
                "google_ai" => ModelModelEndpointType.GoogleAi,
                "google_vertex" => ModelModelEndpointType.GoogleVertex,
                "groq" => ModelModelEndpointType.Groq,
                "hugging-face" => ModelModelEndpointType.HuggingFace,
                "koboldcpp" => ModelModelEndpointType.Koboldcpp,
                "llamacpp" => ModelModelEndpointType.Llamacpp,
                "lmstudio" => ModelModelEndpointType.Lmstudio,
                "lmstudio-chatcompletions" => ModelModelEndpointType.LmstudioChatcompletions,
                "lmstudio-legacy" => ModelModelEndpointType.LmstudioLegacy,
                "minimax" => ModelModelEndpointType.Minimax,
                "mistral" => ModelModelEndpointType.Mistral,
                "ollama" => ModelModelEndpointType.Ollama,
                "openai" => ModelModelEndpointType.Openai,
                "openrouter" => ModelModelEndpointType.Openrouter,
                "together" => ModelModelEndpointType.Together,
                "vllm" => ModelModelEndpointType.Vllm,
                "webui" => ModelModelEndpointType.Webui,
                "webui-legacy" => ModelModelEndpointType.WebuiLegacy,
                "xai" => ModelModelEndpointType.Xai,
                "zai" => ModelModelEndpointType.Zai,
                _ => null,
            };
        }
    }
}