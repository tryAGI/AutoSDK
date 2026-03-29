//HintName: G.Models.PromptVersionInvocationParametersDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionInvocationParametersDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aws")]
        Aws,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure_openai")]
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="cerebras")]
        Cerebras,
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
        [global::System.Runtime.Serialization.EnumMember(Value="moonshot")]
        Moonshot,
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
        [global::System.Runtime.Serialization.EnumMember(Value="perplexity")]
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="together")]
        Together,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PromptVersionInvocationParametersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionInvocationParametersDiscriminatorType value)
        {
            return value switch
            {
                PromptVersionInvocationParametersDiscriminatorType.Anthropic => "anthropic",
                PromptVersionInvocationParametersDiscriminatorType.Aws => "aws",
                PromptVersionInvocationParametersDiscriminatorType.AzureOpenai => "azure_openai",
                PromptVersionInvocationParametersDiscriminatorType.Cerebras => "cerebras",
                PromptVersionInvocationParametersDiscriminatorType.Deepseek => "deepseek",
                PromptVersionInvocationParametersDiscriminatorType.Fireworks => "fireworks",
                PromptVersionInvocationParametersDiscriminatorType.Google => "google",
                PromptVersionInvocationParametersDiscriminatorType.Groq => "groq",
                PromptVersionInvocationParametersDiscriminatorType.Moonshot => "moonshot",
                PromptVersionInvocationParametersDiscriminatorType.Ollama => "ollama",
                PromptVersionInvocationParametersDiscriminatorType.Openai => "openai",
                PromptVersionInvocationParametersDiscriminatorType.Perplexity => "perplexity",
                PromptVersionInvocationParametersDiscriminatorType.Together => "together",
                PromptVersionInvocationParametersDiscriminatorType.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionInvocationParametersDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => PromptVersionInvocationParametersDiscriminatorType.Anthropic,
                "aws" => PromptVersionInvocationParametersDiscriminatorType.Aws,
                "azure_openai" => PromptVersionInvocationParametersDiscriminatorType.AzureOpenai,
                "cerebras" => PromptVersionInvocationParametersDiscriminatorType.Cerebras,
                "deepseek" => PromptVersionInvocationParametersDiscriminatorType.Deepseek,
                "fireworks" => PromptVersionInvocationParametersDiscriminatorType.Fireworks,
                "google" => PromptVersionInvocationParametersDiscriminatorType.Google,
                "groq" => PromptVersionInvocationParametersDiscriminatorType.Groq,
                "moonshot" => PromptVersionInvocationParametersDiscriminatorType.Moonshot,
                "ollama" => PromptVersionInvocationParametersDiscriminatorType.Ollama,
                "openai" => PromptVersionInvocationParametersDiscriminatorType.Openai,
                "perplexity" => PromptVersionInvocationParametersDiscriminatorType.Perplexity,
                "together" => PromptVersionInvocationParametersDiscriminatorType.Together,
                "xai" => PromptVersionInvocationParametersDiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}