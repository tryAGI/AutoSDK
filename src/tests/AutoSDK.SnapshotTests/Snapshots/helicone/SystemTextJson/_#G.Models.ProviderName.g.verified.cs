//HintName: G.Models.ProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ProviderName
    {
        /// <summary>
        /// 
        /// </summary>
        x2yfv,
        /// <summary>
        /// 
        /// </summary>
        Amdbartek,
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
        Avian,
        /// <summary>
        /// 
        /// </summary>
        Aws,
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
        Cloudflare,
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
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        Firecrawl,
        /// <summary>
        /// 
        /// </summary>
        Fireworks,
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
        Helicone,
        /// <summary>
        /// 
        /// </summary>
        Lemonfox,
        /// <summary>
        /// 
        /// </summary>
        Llama,
        /// <summary>
        /// 
        /// </summary>
        Local,
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
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openpipe,
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
        Qstash,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Vercel,
        /// <summary>
        /// 
        /// </summary>
        Wisdominanutshell,
        /// <summary>
        /// 
        /// </summary>
        X,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderName value)
        {
            return value switch
            {
                ProviderName.x2yfv => "2YFV",
                ProviderName.Amdbartek => "AMDBARTEK",
                ProviderName.Anthropic => "ANTHROPIC",
                ProviderName.Anyscale => "ANYSCALE",
                ProviderName.Avian => "AVIAN",
                ProviderName.Aws => "AWS",
                ProviderName.Azure => "AZURE",
                ProviderName.Baseten => "BASETEN",
                ProviderName.Bedrock => "BEDROCK",
                ProviderName.Canopywave => "CANOPYWAVE",
                ProviderName.Cerebras => "CEREBRAS",
                ProviderName.Chutes => "CHUTES",
                ProviderName.Cloudflare => "CLOUDFLARE",
                ProviderName.Cohere => "COHERE",
                ProviderName.Deepinfra => "DEEPINFRA",
                ProviderName.Deepseek => "DEEPSEEK",
                ProviderName.Firecrawl => "FIRECRAWL",
                ProviderName.Fireworks => "FIREWORKS",
                ProviderName.Google => "GOOGLE",
                ProviderName.Groq => "GROQ",
                ProviderName.Helicone => "HELICONE",
                ProviderName.Lemonfox => "LEMONFOX",
                ProviderName.Llama => "LLAMA",
                ProviderName.Local => "LOCAL",
                ProviderName.Mistral => "MISTRAL",
                ProviderName.Nebius => "NEBIUS",
                ProviderName.Novita => "NOVITA",
                ProviderName.Nvidia => "NVIDIA",
                ProviderName.Openai => "OPENAI",
                ProviderName.Openpipe => "OPENPIPE",
                ProviderName.Openrouter => "OPENROUTER",
                ProviderName.Perplexity => "PERPLEXITY",
                ProviderName.Qstash => "QSTASH",
                ProviderName.Together => "TOGETHER",
                ProviderName.Vercel => "VERCEL",
                ProviderName.Wisdominanutshell => "WISDOMINANUTSHELL",
                ProviderName.X => "X",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderName? ToEnum(string value)
        {
            return value switch
            {
                "2YFV" => ProviderName.x2yfv,
                "AMDBARTEK" => ProviderName.Amdbartek,
                "ANTHROPIC" => ProviderName.Anthropic,
                "ANYSCALE" => ProviderName.Anyscale,
                "AVIAN" => ProviderName.Avian,
                "AWS" => ProviderName.Aws,
                "AZURE" => ProviderName.Azure,
                "BASETEN" => ProviderName.Baseten,
                "BEDROCK" => ProviderName.Bedrock,
                "CANOPYWAVE" => ProviderName.Canopywave,
                "CEREBRAS" => ProviderName.Cerebras,
                "CHUTES" => ProviderName.Chutes,
                "CLOUDFLARE" => ProviderName.Cloudflare,
                "COHERE" => ProviderName.Cohere,
                "DEEPINFRA" => ProviderName.Deepinfra,
                "DEEPSEEK" => ProviderName.Deepseek,
                "FIRECRAWL" => ProviderName.Firecrawl,
                "FIREWORKS" => ProviderName.Fireworks,
                "GOOGLE" => ProviderName.Google,
                "GROQ" => ProviderName.Groq,
                "HELICONE" => ProviderName.Helicone,
                "LEMONFOX" => ProviderName.Lemonfox,
                "LLAMA" => ProviderName.Llama,
                "LOCAL" => ProviderName.Local,
                "MISTRAL" => ProviderName.Mistral,
                "NEBIUS" => ProviderName.Nebius,
                "NOVITA" => ProviderName.Novita,
                "NVIDIA" => ProviderName.Nvidia,
                "OPENAI" => ProviderName.Openai,
                "OPENPIPE" => ProviderName.Openpipe,
                "OPENROUTER" => ProviderName.Openrouter,
                "PERPLEXITY" => ProviderName.Perplexity,
                "QSTASH" => ProviderName.Qstash,
                "TOGETHER" => ProviderName.Together,
                "VERCEL" => ProviderName.Vercel,
                "WISDOMINANUTSHELL" => ProviderName.Wisdominanutshell,
                "X" => ProviderName.X,
                _ => null,
            };
        }
    }
}