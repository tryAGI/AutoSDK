//HintName: G.Models.EmbeddingModelEmbeddingEndpointType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Deprecated: Use 'provider_type' field instead. The endpoint type for the embedding model.
    /// </summary>
    public enum EmbeddingModelEmbeddingEndpointType
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
        LmstudioLegacy,
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
        Pinecone,
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