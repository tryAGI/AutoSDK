//HintName: G.Models.EmbeddingModelEmbeddingEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: Use 'provider_type' field instead. The endpoint type for the embedding model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmbeddingModelEmbeddingEndpointType
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
    public static class EmbeddingModelEmbeddingEndpointTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingModelEmbeddingEndpointType value)
        {
            return value switch
            {
                EmbeddingModelEmbeddingEndpointType.Anthropic => "anthropic",
                EmbeddingModelEmbeddingEndpointType.Azure => "azure",
                EmbeddingModelEmbeddingEndpointType.Bedrock => "bedrock",
                EmbeddingModelEmbeddingEndpointType.GoogleAi => "google_ai",
                EmbeddingModelEmbeddingEndpointType.GoogleVertex => "google_vertex",
                EmbeddingModelEmbeddingEndpointType.Groq => "groq",
                EmbeddingModelEmbeddingEndpointType.HuggingFace => "hugging-face",
                EmbeddingModelEmbeddingEndpointType.Koboldcpp => "koboldcpp",
                EmbeddingModelEmbeddingEndpointType.Llamacpp => "llamacpp",
                EmbeddingModelEmbeddingEndpointType.Lmstudio => "lmstudio",
                EmbeddingModelEmbeddingEndpointType.LmstudioLegacy => "lmstudio-legacy",
                EmbeddingModelEmbeddingEndpointType.Mistral => "mistral",
                EmbeddingModelEmbeddingEndpointType.Ollama => "ollama",
                EmbeddingModelEmbeddingEndpointType.Openai => "openai",
                EmbeddingModelEmbeddingEndpointType.Pinecone => "pinecone",
                EmbeddingModelEmbeddingEndpointType.Together => "together",
                EmbeddingModelEmbeddingEndpointType.Vllm => "vllm",
                EmbeddingModelEmbeddingEndpointType.Webui => "webui",
                EmbeddingModelEmbeddingEndpointType.WebuiLegacy => "webui-legacy",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingModelEmbeddingEndpointType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => EmbeddingModelEmbeddingEndpointType.Anthropic,
                "azure" => EmbeddingModelEmbeddingEndpointType.Azure,
                "bedrock" => EmbeddingModelEmbeddingEndpointType.Bedrock,
                "google_ai" => EmbeddingModelEmbeddingEndpointType.GoogleAi,
                "google_vertex" => EmbeddingModelEmbeddingEndpointType.GoogleVertex,
                "groq" => EmbeddingModelEmbeddingEndpointType.Groq,
                "hugging-face" => EmbeddingModelEmbeddingEndpointType.HuggingFace,
                "koboldcpp" => EmbeddingModelEmbeddingEndpointType.Koboldcpp,
                "llamacpp" => EmbeddingModelEmbeddingEndpointType.Llamacpp,
                "lmstudio" => EmbeddingModelEmbeddingEndpointType.Lmstudio,
                "lmstudio-legacy" => EmbeddingModelEmbeddingEndpointType.LmstudioLegacy,
                "mistral" => EmbeddingModelEmbeddingEndpointType.Mistral,
                "ollama" => EmbeddingModelEmbeddingEndpointType.Ollama,
                "openai" => EmbeddingModelEmbeddingEndpointType.Openai,
                "pinecone" => EmbeddingModelEmbeddingEndpointType.Pinecone,
                "together" => EmbeddingModelEmbeddingEndpointType.Together,
                "vllm" => EmbeddingModelEmbeddingEndpointType.Vllm,
                "webui" => EmbeddingModelEmbeddingEndpointType.Webui,
                "webui-legacy" => EmbeddingModelEmbeddingEndpointType.WebuiLegacy,
                _ => null,
            };
        }
    }
}