//HintName: G.Models.EmbeddingConfigEmbeddingEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The endpoint type for the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingConfigEmbeddingEndpointType
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
        [global::System.Runtime.Serialization.EnumMember(Value="lmstudio-legacy")]
        LmstudioLegacy,
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
        [global::System.Runtime.Serialization.EnumMember(Value="pinecone")]
        Pinecone,
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
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingConfigEmbeddingEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingConfigEmbeddingEndpointType value)
        {
            return value switch
            {
                EmbeddingConfigEmbeddingEndpointType.Anthropic => "anthropic",
                EmbeddingConfigEmbeddingEndpointType.Azure => "azure",
                EmbeddingConfigEmbeddingEndpointType.Bedrock => "bedrock",
                EmbeddingConfigEmbeddingEndpointType.GoogleAi => "google_ai",
                EmbeddingConfigEmbeddingEndpointType.GoogleVertex => "google_vertex",
                EmbeddingConfigEmbeddingEndpointType.Groq => "groq",
                EmbeddingConfigEmbeddingEndpointType.HuggingFace => "hugging-face",
                EmbeddingConfigEmbeddingEndpointType.Koboldcpp => "koboldcpp",
                EmbeddingConfigEmbeddingEndpointType.Llamacpp => "llamacpp",
                EmbeddingConfigEmbeddingEndpointType.Lmstudio => "lmstudio",
                EmbeddingConfigEmbeddingEndpointType.LmstudioLegacy => "lmstudio-legacy",
                EmbeddingConfigEmbeddingEndpointType.Mistral => "mistral",
                EmbeddingConfigEmbeddingEndpointType.Ollama => "ollama",
                EmbeddingConfigEmbeddingEndpointType.Openai => "openai",
                EmbeddingConfigEmbeddingEndpointType.Pinecone => "pinecone",
                EmbeddingConfigEmbeddingEndpointType.Together => "together",
                EmbeddingConfigEmbeddingEndpointType.Vllm => "vllm",
                EmbeddingConfigEmbeddingEndpointType.Webui => "webui",
                EmbeddingConfigEmbeddingEndpointType.WebuiLegacy => "webui-legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingConfigEmbeddingEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EmbeddingConfigEmbeddingEndpointType.Anthropic,
                "azure" => EmbeddingConfigEmbeddingEndpointType.Azure,
                "bedrock" => EmbeddingConfigEmbeddingEndpointType.Bedrock,
                "google_ai" => EmbeddingConfigEmbeddingEndpointType.GoogleAi,
                "google_vertex" => EmbeddingConfigEmbeddingEndpointType.GoogleVertex,
                "groq" => EmbeddingConfigEmbeddingEndpointType.Groq,
                "hugging-face" => EmbeddingConfigEmbeddingEndpointType.HuggingFace,
                "koboldcpp" => EmbeddingConfigEmbeddingEndpointType.Koboldcpp,
                "llamacpp" => EmbeddingConfigEmbeddingEndpointType.Llamacpp,
                "lmstudio" => EmbeddingConfigEmbeddingEndpointType.Lmstudio,
                "lmstudio-legacy" => EmbeddingConfigEmbeddingEndpointType.LmstudioLegacy,
                "mistral" => EmbeddingConfigEmbeddingEndpointType.Mistral,
                "ollama" => EmbeddingConfigEmbeddingEndpointType.Ollama,
                "openai" => EmbeddingConfigEmbeddingEndpointType.Openai,
                "pinecone" => EmbeddingConfigEmbeddingEndpointType.Pinecone,
                "together" => EmbeddingConfigEmbeddingEndpointType.Together,
                "vllm" => EmbeddingConfigEmbeddingEndpointType.Vllm,
                "webui" => EmbeddingConfigEmbeddingEndpointType.Webui,
                "webui-legacy" => EmbeddingConfigEmbeddingEndpointType.WebuiLegacy,
                _ => null,
            };
        }
    }
}