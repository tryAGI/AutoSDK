//HintName: G.Models.ModelProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="ANTHROPIC")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AWS")]
        Aws,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AZURE_OPENAI")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="CEREBRAS")]
        Cerebras,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="DEEPSEEK")]
        Deepseek,
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
        [global::System.Runtime.Serialization.EnumMember(Value="MOONSHOT")]
        Moonshot,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OLLAMA")]
        Ollama,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OPENAI")]
        Openai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="PERPLEXITY")]
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="TOGETHER")]
        Together,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="XAI")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelProvider value)
        {
            return value switch
            {
                ModelProvider.Anthropic => "ANTHROPIC",
                ModelProvider.Aws => "AWS",
                ModelProvider.AzureOpenai => "AZURE_OPENAI",
                ModelProvider.Cerebras => "CEREBRAS",
                ModelProvider.Deepseek => "DEEPSEEK",
                ModelProvider.Fireworks => "FIREWORKS",
                ModelProvider.Google => "GOOGLE",
                ModelProvider.Groq => "GROQ",
                ModelProvider.Moonshot => "MOONSHOT",
                ModelProvider.Ollama => "OLLAMA",
                ModelProvider.Openai => "OPENAI",
                ModelProvider.Perplexity => "PERPLEXITY",
                ModelProvider.Together => "TOGETHER",
                ModelProvider.Xai => "XAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelProvider? ToEnum(string value)
        {
            return value switch
            {
                "ANTHROPIC" => ModelProvider.Anthropic,
                "AWS" => ModelProvider.Aws,
                "AZURE_OPENAI" => ModelProvider.AzureOpenai,
                "CEREBRAS" => ModelProvider.Cerebras,
                "DEEPSEEK" => ModelProvider.Deepseek,
                "FIREWORKS" => ModelProvider.Fireworks,
                "GOOGLE" => ModelProvider.Google,
                "GROQ" => ModelProvider.Groq,
                "MOONSHOT" => ModelProvider.Moonshot,
                "OLLAMA" => ModelProvider.Ollama,
                "OPENAI" => ModelProvider.Openai,
                "PERPLEXITY" => ModelProvider.Perplexity,
                "TOGETHER" => ModelProvider.Together,
                "XAI" => ModelProvider.Xai,
                _ => null,
            };
        }
    }
}