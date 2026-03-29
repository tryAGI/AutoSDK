//HintName: G.Models.CreateVirtualKeysRequestProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateVirtualKeysRequestProvider
    {
        /// <summary>
        /// 
        /// </summary>
        Ai21,
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        FireworksAi,
        /// <summary>
        /// 
        /// </summary>
        Google,
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
        Jina,
        /// <summary>
        /// 
        /// </summary>
        Lingyi,
        /// <summary>
        /// 
        /// </summary>
        MistralAi,
        /// <summary>
        /// 
        /// </summary>
        Monsterapi,
        /// <summary>
        /// 
        /// </summary>
        Moonshot,
        /// <summary>
        /// 
        /// </summary>
        Nomic,
        /// <summary>
        /// 
        /// </summary>
        NovitaAi,
        /// <summary>
        /// 
        /// </summary>
        OpenAi2,
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
        Palm,
        /// <summary>
        /// 
        /// </summary>
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        Predibase,
        /// <summary>
        /// 
        /// </summary>
        RekaAi,
        /// <summary>
        /// 
        /// </summary>
        Segmind,
        /// <summary>
        /// 
        /// </summary>
        StabilityAi,
        /// <summary>
        /// 
        /// </summary>
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        VertexAi,
        /// <summary>
        /// 
        /// </summary>
        WorkersAi,
        /// <summary>
        /// 
        /// </summary>
        Zhipu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateVirtualKeysRequestProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateVirtualKeysRequestProvider value)
        {
            return value switch
            {
                CreateVirtualKeysRequestProvider.Ai21 => "ai21",
                CreateVirtualKeysRequestProvider.Anthropic => "anthropic",
                CreateVirtualKeysRequestProvider.Anyscale => "anyscale",
                CreateVirtualKeysRequestProvider.AzureOpenai => "azure-openai",
                CreateVirtualKeysRequestProvider.Bedrock => "bedrock",
                CreateVirtualKeysRequestProvider.Cohere => "cohere",
                CreateVirtualKeysRequestProvider.Deepinfra => "deepinfra",
                CreateVirtualKeysRequestProvider.FireworksAi => "fireworks-ai",
                CreateVirtualKeysRequestProvider.Google => "google",
                CreateVirtualKeysRequestProvider.Groq => "groq",
                CreateVirtualKeysRequestProvider.HuggingFace => "hugging-face",
                CreateVirtualKeysRequestProvider.Jina => "jina",
                CreateVirtualKeysRequestProvider.Lingyi => "lingyi",
                CreateVirtualKeysRequestProvider.MistralAi => "mistral-ai",
                CreateVirtualKeysRequestProvider.Monsterapi => "monsterapi",
                CreateVirtualKeysRequestProvider.Moonshot => "moonshot",
                CreateVirtualKeysRequestProvider.Nomic => "nomic",
                CreateVirtualKeysRequestProvider.NovitaAi => "novita-ai",
                CreateVirtualKeysRequestProvider.OpenAi2 => "open-ai",
                CreateVirtualKeysRequestProvider.Openai => "openai",
                CreateVirtualKeysRequestProvider.Openrouter => "openrouter",
                CreateVirtualKeysRequestProvider.Palm => "palm",
                CreateVirtualKeysRequestProvider.PerplexityAi => "perplexity-ai",
                CreateVirtualKeysRequestProvider.Predibase => "predibase",
                CreateVirtualKeysRequestProvider.RekaAi => "reka-ai",
                CreateVirtualKeysRequestProvider.Segmind => "segmind",
                CreateVirtualKeysRequestProvider.StabilityAi => "stability-ai",
                CreateVirtualKeysRequestProvider.TogetherAi => "together-ai",
                CreateVirtualKeysRequestProvider.VertexAi => "vertex-ai",
                CreateVirtualKeysRequestProvider.WorkersAi => "workers-ai",
                CreateVirtualKeysRequestProvider.Zhipu => "zhipu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateVirtualKeysRequestProvider? ToEnum(string value)
        {
            return value switch
            {
                "ai21" => CreateVirtualKeysRequestProvider.Ai21,
                "anthropic" => CreateVirtualKeysRequestProvider.Anthropic,
                "anyscale" => CreateVirtualKeysRequestProvider.Anyscale,
                "azure-openai" => CreateVirtualKeysRequestProvider.AzureOpenai,
                "bedrock" => CreateVirtualKeysRequestProvider.Bedrock,
                "cohere" => CreateVirtualKeysRequestProvider.Cohere,
                "deepinfra" => CreateVirtualKeysRequestProvider.Deepinfra,
                "fireworks-ai" => CreateVirtualKeysRequestProvider.FireworksAi,
                "google" => CreateVirtualKeysRequestProvider.Google,
                "groq" => CreateVirtualKeysRequestProvider.Groq,
                "hugging-face" => CreateVirtualKeysRequestProvider.HuggingFace,
                "jina" => CreateVirtualKeysRequestProvider.Jina,
                "lingyi" => CreateVirtualKeysRequestProvider.Lingyi,
                "mistral-ai" => CreateVirtualKeysRequestProvider.MistralAi,
                "monsterapi" => CreateVirtualKeysRequestProvider.Monsterapi,
                "moonshot" => CreateVirtualKeysRequestProvider.Moonshot,
                "nomic" => CreateVirtualKeysRequestProvider.Nomic,
                "novita-ai" => CreateVirtualKeysRequestProvider.NovitaAi,
                "open-ai" => CreateVirtualKeysRequestProvider.OpenAi2,
                "openai" => CreateVirtualKeysRequestProvider.Openai,
                "openrouter" => CreateVirtualKeysRequestProvider.Openrouter,
                "palm" => CreateVirtualKeysRequestProvider.Palm,
                "perplexity-ai" => CreateVirtualKeysRequestProvider.PerplexityAi,
                "predibase" => CreateVirtualKeysRequestProvider.Predibase,
                "reka-ai" => CreateVirtualKeysRequestProvider.RekaAi,
                "segmind" => CreateVirtualKeysRequestProvider.Segmind,
                "stability-ai" => CreateVirtualKeysRequestProvider.StabilityAi,
                "together-ai" => CreateVirtualKeysRequestProvider.TogetherAi,
                "vertex-ai" => CreateVirtualKeysRequestProvider.VertexAi,
                "workers-ai" => CreateVirtualKeysRequestProvider.WorkersAi,
                "zhipu" => CreateVirtualKeysRequestProvider.Zhipu,
                _ => null,
            };
        }
    }
}