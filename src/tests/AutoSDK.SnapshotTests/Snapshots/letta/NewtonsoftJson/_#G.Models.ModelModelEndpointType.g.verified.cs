//HintName: G.Models.ModelModelEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: Use 'provider_type' field instead. The endpoint type for the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelModelEndpointType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatgpt_oauth")]
        ChatgptOauth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek")]
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google_ai")]
        GoogleAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google_vertex")]
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="hugging-face")]
        HuggingFace,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="koboldcpp")]
        Koboldcpp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="llamacpp")]
        Llamacpp,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmstudio")]
        Lmstudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmstudio-chatcompletions")]
        LmstudioChatcompletions,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmstudio-legacy")]
        LmstudioLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="minimax")]
        Minimax,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ollama")]
        Ollama,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openai")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter")]
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together")]
        Together,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vllm")]
        Vllm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webui")]
        Webui,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="webui-legacy")]
        WebuiLegacy,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zai")]
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