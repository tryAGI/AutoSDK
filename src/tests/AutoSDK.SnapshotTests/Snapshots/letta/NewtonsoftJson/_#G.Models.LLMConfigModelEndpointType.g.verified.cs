//HintName: G.Models.LLMConfigModelEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint type for the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LLMConfigModelEndpointType
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