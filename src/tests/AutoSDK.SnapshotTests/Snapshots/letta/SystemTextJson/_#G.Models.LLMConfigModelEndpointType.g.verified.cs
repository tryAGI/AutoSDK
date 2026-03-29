//HintName: G.Models.LLMConfigModelEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint type for the model.
    /// </summary>
    public enum LLMConfigModelEndpointType
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
    public static class LLMConfigModelEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LLMConfigModelEndpointType value)
        {
            return value switch
            {
                LLMConfigModelEndpointType.Anthropic => "anthropic",
                LLMConfigModelEndpointType.Azure => "azure",
                LLMConfigModelEndpointType.Bedrock => "bedrock",
                LLMConfigModelEndpointType.ChatgptOauth => "chatgpt_oauth",
                LLMConfigModelEndpointType.Deepseek => "deepseek",
                LLMConfigModelEndpointType.GoogleAi => "google_ai",
                LLMConfigModelEndpointType.GoogleVertex => "google_vertex",
                LLMConfigModelEndpointType.Groq => "groq",
                LLMConfigModelEndpointType.HuggingFace => "hugging-face",
                LLMConfigModelEndpointType.Koboldcpp => "koboldcpp",
                LLMConfigModelEndpointType.Llamacpp => "llamacpp",
                LLMConfigModelEndpointType.Lmstudio => "lmstudio",
                LLMConfigModelEndpointType.LmstudioChatcompletions => "lmstudio-chatcompletions",
                LLMConfigModelEndpointType.LmstudioLegacy => "lmstudio-legacy",
                LLMConfigModelEndpointType.Minimax => "minimax",
                LLMConfigModelEndpointType.Mistral => "mistral",
                LLMConfigModelEndpointType.Ollama => "ollama",
                LLMConfigModelEndpointType.Openai => "openai",
                LLMConfigModelEndpointType.Openrouter => "openrouter",
                LLMConfigModelEndpointType.Together => "together",
                LLMConfigModelEndpointType.Vllm => "vllm",
                LLMConfigModelEndpointType.Webui => "webui",
                LLMConfigModelEndpointType.WebuiLegacy => "webui-legacy",
                LLMConfigModelEndpointType.Xai => "xai",
                LLMConfigModelEndpointType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LLMConfigModelEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LLMConfigModelEndpointType.Anthropic,
                "azure" => LLMConfigModelEndpointType.Azure,
                "bedrock" => LLMConfigModelEndpointType.Bedrock,
                "chatgpt_oauth" => LLMConfigModelEndpointType.ChatgptOauth,
                "deepseek" => LLMConfigModelEndpointType.Deepseek,
                "google_ai" => LLMConfigModelEndpointType.GoogleAi,
                "google_vertex" => LLMConfigModelEndpointType.GoogleVertex,
                "groq" => LLMConfigModelEndpointType.Groq,
                "hugging-face" => LLMConfigModelEndpointType.HuggingFace,
                "koboldcpp" => LLMConfigModelEndpointType.Koboldcpp,
                "llamacpp" => LLMConfigModelEndpointType.Llamacpp,
                "lmstudio" => LLMConfigModelEndpointType.Lmstudio,
                "lmstudio-chatcompletions" => LLMConfigModelEndpointType.LmstudioChatcompletions,
                "lmstudio-legacy" => LLMConfigModelEndpointType.LmstudioLegacy,
                "minimax" => LLMConfigModelEndpointType.Minimax,
                "mistral" => LLMConfigModelEndpointType.Mistral,
                "ollama" => LLMConfigModelEndpointType.Ollama,
                "openai" => LLMConfigModelEndpointType.Openai,
                "openrouter" => LLMConfigModelEndpointType.Openrouter,
                "together" => LLMConfigModelEndpointType.Together,
                "vllm" => LLMConfigModelEndpointType.Vllm,
                "webui" => LLMConfigModelEndpointType.Webui,
                "webui-legacy" => LLMConfigModelEndpointType.WebuiLegacy,
                "xai" => LLMConfigModelEndpointType.Xai,
                "zai" => LLMConfigModelEndpointType.Zai,
                _ => null,
            };
        }
    }
}