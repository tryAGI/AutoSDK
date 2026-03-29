//HintName: G.Models.DeleteProviderKeyResponseVariant1ProviderName.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum DeleteProviderKeyResponseVariant1ProviderName
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
    public static class DeleteProviderKeyResponseVariant1ProviderNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteProviderKeyResponseVariant1ProviderName value)
        {
            return value switch
            {
                DeleteProviderKeyResponseVariant1ProviderName.Anthropic => "anthropic",
                DeleteProviderKeyResponseVariant1ProviderName.Azure => "azure",
                DeleteProviderKeyResponseVariant1ProviderName.Baseten => "baseten",
                DeleteProviderKeyResponseVariant1ProviderName.Bedrock => "bedrock",
                DeleteProviderKeyResponseVariant1ProviderName.Canopywave => "canopywave",
                DeleteProviderKeyResponseVariant1ProviderName.Cerebras => "cerebras",
                DeleteProviderKeyResponseVariant1ProviderName.Chutes => "chutes",
                DeleteProviderKeyResponseVariant1ProviderName.Deepinfra => "deepinfra",
                DeleteProviderKeyResponseVariant1ProviderName.Deepseek => "deepseek",
                DeleteProviderKeyResponseVariant1ProviderName.Fireworks => "fireworks",
                DeleteProviderKeyResponseVariant1ProviderName.GoogleAiStudio => "google-ai-studio",
                DeleteProviderKeyResponseVariant1ProviderName.Groq => "groq",
                DeleteProviderKeyResponseVariant1ProviderName.Helicone => "helicone",
                DeleteProviderKeyResponseVariant1ProviderName.Mistral => "mistral",
                DeleteProviderKeyResponseVariant1ProviderName.Nebius => "nebius",
                DeleteProviderKeyResponseVariant1ProviderName.Novita => "novita",
                DeleteProviderKeyResponseVariant1ProviderName.Openai => "openai",
                DeleteProviderKeyResponseVariant1ProviderName.Openrouter => "openrouter",
                DeleteProviderKeyResponseVariant1ProviderName.Perplexity => "perplexity",
                DeleteProviderKeyResponseVariant1ProviderName.Vertex => "vertex",
                DeleteProviderKeyResponseVariant1ProviderName.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteProviderKeyResponseVariant1ProviderName? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => DeleteProviderKeyResponseVariant1ProviderName.Anthropic,
                "azure" => DeleteProviderKeyResponseVariant1ProviderName.Azure,
                "baseten" => DeleteProviderKeyResponseVariant1ProviderName.Baseten,
                "bedrock" => DeleteProviderKeyResponseVariant1ProviderName.Bedrock,
                "canopywave" => DeleteProviderKeyResponseVariant1ProviderName.Canopywave,
                "cerebras" => DeleteProviderKeyResponseVariant1ProviderName.Cerebras,
                "chutes" => DeleteProviderKeyResponseVariant1ProviderName.Chutes,
                "deepinfra" => DeleteProviderKeyResponseVariant1ProviderName.Deepinfra,
                "deepseek" => DeleteProviderKeyResponseVariant1ProviderName.Deepseek,
                "fireworks" => DeleteProviderKeyResponseVariant1ProviderName.Fireworks,
                "google-ai-studio" => DeleteProviderKeyResponseVariant1ProviderName.GoogleAiStudio,
                "groq" => DeleteProviderKeyResponseVariant1ProviderName.Groq,
                "helicone" => DeleteProviderKeyResponseVariant1ProviderName.Helicone,
                "mistral" => DeleteProviderKeyResponseVariant1ProviderName.Mistral,
                "nebius" => DeleteProviderKeyResponseVariant1ProviderName.Nebius,
                "novita" => DeleteProviderKeyResponseVariant1ProviderName.Novita,
                "openai" => DeleteProviderKeyResponseVariant1ProviderName.Openai,
                "openrouter" => DeleteProviderKeyResponseVariant1ProviderName.Openrouter,
                "perplexity" => DeleteProviderKeyResponseVariant1ProviderName.Perplexity,
                "vertex" => DeleteProviderKeyResponseVariant1ProviderName.Vertex,
                "xai" => DeleteProviderKeyResponseVariant1ProviderName.Xai,
                _ => null,
            };
        }
    }
}