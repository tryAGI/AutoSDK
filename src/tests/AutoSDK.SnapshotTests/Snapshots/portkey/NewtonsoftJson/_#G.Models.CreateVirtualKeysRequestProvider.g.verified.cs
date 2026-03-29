//HintName: G.Models.CreateVirtualKeysRequestProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateVirtualKeysRequestProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ai21")]
        Ai21,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anyscale")]
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cohere")]
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fireworks-ai")]
        FireworksAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google")]
        Google,
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
        [global::System.Runtime.Serialization.EnumMember(Value="jina")]
        Jina,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="lingyi")]
        Lingyi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral-ai")]
        MistralAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monsterapi")]
        Monsterapi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="moonshot")]
        Moonshot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nomic")]
        Nomic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="novita-ai")]
        NovitaAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="open-ai")]
        OpenAi2,
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
        [global::System.Runtime.Serialization.EnumMember(Value="palm")]
        Palm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity-ai")]
        PerplexityAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="predibase")]
        Predibase,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="reka-ai")]
        RekaAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="segmind")]
        Segmind,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="stability-ai")]
        StabilityAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together-ai")]
        TogetherAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex-ai")]
        VertexAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="workers-ai")]
        WorkersAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zhipu")]
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