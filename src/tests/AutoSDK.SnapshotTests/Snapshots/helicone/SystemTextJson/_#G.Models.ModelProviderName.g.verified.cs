//HintName: G.Models.ModelProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelProviderName
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
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        Canopywave,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        Chutes,
        /// <summary>
        /// 
        /// </summary>
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        GoogleAiStudio,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Helicone,
        /// <summary>
        /// 
        /// </summary>
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        Nebius,
        /// <summary>
        /// 
        /// </summary>
        Novita,
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
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Vertex,
        /// <summary>
        /// 
        /// </summary>
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