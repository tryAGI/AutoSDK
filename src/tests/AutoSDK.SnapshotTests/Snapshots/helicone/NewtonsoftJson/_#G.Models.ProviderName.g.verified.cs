//HintName: G.Models.ProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderName
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="2YFV")]
        x2yfv,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AMDBARTEK")]
        Amdbartek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANTHROPIC")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANYSCALE")]
        Anyscale,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AVIAN")]
        Avian,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWS")]
        Aws,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE")]
        Azure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BASETEN")]
        Baseten,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="BEDROCK")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CANOPYWAVE")]
        Canopywave,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CEREBRAS")]
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CHUTES")]
        Chutes,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CLOUDFLARE")]
        Cloudflare,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="COHERE")]
        Cohere,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEEPINFRA")]
        Deepinfra,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEEPSEEK")]
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIRECRAWL")]
        Firecrawl,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="FIREWORKS")]
        Fireworks,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GOOGLE")]
        Google,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="GROQ")]
        Groq,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="HELICONE")]
        Helicone,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LEMONFOX")]
        Lemonfox,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LLAMA")]
        Llama,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="LOCAL")]
        Local,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="MISTRAL")]
        Mistral,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NEBIUS")]
        Nebius,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NOVITA")]
        Novita,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="NVIDIA")]
        Nvidia,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENAI")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENPIPE")]
        Openpipe,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENROUTER")]
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PERPLEXITY")]
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="QSTASH")]
        Qstash,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOGETHER")]
        Together,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VERCEL")]
        Vercel,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="WISDOMINANUTSHELL")]
        Wisdominanutshell,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="X")]
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