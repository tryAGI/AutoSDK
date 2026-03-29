//HintName: G.Models.ProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderType
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
        [global::System.Runtime.Serialization.EnumMember(Value="cerebras")]
        Cerebras,
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
        [global::System.Runtime.Serialization.EnumMember(Value="letta")]
        Letta,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lmstudio_openai")]
        LmstudioOpenai,
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
        [global::System.Runtime.Serialization.EnumMember(Value="sglang")]
        Sglang,
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