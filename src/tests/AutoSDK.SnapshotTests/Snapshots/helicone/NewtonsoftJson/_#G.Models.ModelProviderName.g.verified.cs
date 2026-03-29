//HintName: G.Models.ModelProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelProviderName
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
        [global::System.Runtime.Serialization.EnumMember(Value="baseten")]
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="canopywave")]
        Canopywave,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cerebras")]
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chutes")]
        Chutes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepinfra")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek")]
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="fireworks")]
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google-ai-studio")]
        GoogleAiStudio,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="helicone")]
        Helicone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="mistral")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nebius")]
        Nebius,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="novita")]
        Novita,
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
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity")]
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex")]
        Vertex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProviderName value)
        {
            return value switch
            {
                ModelProviderName.Anthropic => "anthropic",
                ModelProviderName.Azure => "azure",
                ModelProviderName.Baseten => "baseten",
                ModelProviderName.Bedrock => "bedrock",
                ModelProviderName.Canopywave => "canopywave",
                ModelProviderName.Cerebras => "cerebras",
                ModelProviderName.Chutes => "chutes",
                ModelProviderName.Deepinfra => "deepinfra",
                ModelProviderName.Deepseek => "deepseek",
                ModelProviderName.Fireworks => "fireworks",
                ModelProviderName.GoogleAiStudio => "google-ai-studio",
                ModelProviderName.Groq => "groq",
                ModelProviderName.Helicone => "helicone",
                ModelProviderName.Mistral => "mistral",
                ModelProviderName.Nebius => "nebius",
                ModelProviderName.Novita => "novita",
                ModelProviderName.Openai => "openai",
                ModelProviderName.Openrouter => "openrouter",
                ModelProviderName.Perplexity => "perplexity",
                ModelProviderName.Vertex => "vertex",
                ModelProviderName.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProviderName? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ModelProviderName.Anthropic,
                "azure" => ModelProviderName.Azure,
                "baseten" => ModelProviderName.Baseten,
                "bedrock" => ModelProviderName.Bedrock,
                "canopywave" => ModelProviderName.Canopywave,
                "cerebras" => ModelProviderName.Cerebras,
                "chutes" => ModelProviderName.Chutes,
                "deepinfra" => ModelProviderName.Deepinfra,
                "deepseek" => ModelProviderName.Deepseek,
                "fireworks" => ModelProviderName.Fireworks,
                "google-ai-studio" => ModelProviderName.GoogleAiStudio,
                "groq" => ModelProviderName.Groq,
                "helicone" => ModelProviderName.Helicone,
                "mistral" => ModelProviderName.Mistral,
                "nebius" => ModelProviderName.Nebius,
                "novita" => ModelProviderName.Novita,
                "openai" => ModelProviderName.Openai,
                "openrouter" => ModelProviderName.Openrouter,
                "perplexity" => ModelProviderName.Perplexity,
                "vertex" => ModelProviderName.Vertex,
                "xai" => ModelProviderName.Xai,
                _ => null,
            };
        }
    }
}