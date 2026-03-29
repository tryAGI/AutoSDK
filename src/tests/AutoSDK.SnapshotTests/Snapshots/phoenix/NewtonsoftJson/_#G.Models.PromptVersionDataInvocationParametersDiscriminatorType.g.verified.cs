//HintName: G.Models.PromptVersionDataInvocationParametersDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PromptVersionDataInvocationParametersDiscriminatorType
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
    public static class PromptVersionDataInvocationParametersDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptVersionDataInvocationParametersDiscriminatorType value)
        {
            return value switch
            {
                PromptVersionDataInvocationParametersDiscriminatorType.Anthropic => "anthropic",
                PromptVersionDataInvocationParametersDiscriminatorType.Aws => "aws",
                PromptVersionDataInvocationParametersDiscriminatorType.AzureOpenai => "azure_openai",
                PromptVersionDataInvocationParametersDiscriminatorType.Cerebras => "cerebras",
                PromptVersionDataInvocationParametersDiscriminatorType.Deepseek => "deepseek",
                PromptVersionDataInvocationParametersDiscriminatorType.Fireworks => "fireworks",
                PromptVersionDataInvocationParametersDiscriminatorType.Google => "google",
                PromptVersionDataInvocationParametersDiscriminatorType.Groq => "groq",
                PromptVersionDataInvocationParametersDiscriminatorType.Moonshot => "moonshot",
                PromptVersionDataInvocationParametersDiscriminatorType.Ollama => "ollama",
                PromptVersionDataInvocationParametersDiscriminatorType.Openai => "openai",
                PromptVersionDataInvocationParametersDiscriminatorType.Perplexity => "perplexity",
                PromptVersionDataInvocationParametersDiscriminatorType.Together => "together",
                PromptVersionDataInvocationParametersDiscriminatorType.Xai => "xai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptVersionDataInvocationParametersDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => PromptVersionDataInvocationParametersDiscriminatorType.Anthropic,
                "aws" => PromptVersionDataInvocationParametersDiscriminatorType.Aws,
                "azure_openai" => PromptVersionDataInvocationParametersDiscriminatorType.AzureOpenai,
                "cerebras" => PromptVersionDataInvocationParametersDiscriminatorType.Cerebras,
                "deepseek" => PromptVersionDataInvocationParametersDiscriminatorType.Deepseek,
                "fireworks" => PromptVersionDataInvocationParametersDiscriminatorType.Fireworks,
                "google" => PromptVersionDataInvocationParametersDiscriminatorType.Google,
                "groq" => PromptVersionDataInvocationParametersDiscriminatorType.Groq,
                "moonshot" => PromptVersionDataInvocationParametersDiscriminatorType.Moonshot,
                "ollama" => PromptVersionDataInvocationParametersDiscriminatorType.Ollama,
                "openai" => PromptVersionDataInvocationParametersDiscriminatorType.Openai,
                "perplexity" => PromptVersionDataInvocationParametersDiscriminatorType.Perplexity,
                "together" => PromptVersionDataInvocationParametersDiscriminatorType.Together,
                "xai" => PromptVersionDataInvocationParametersDiscriminatorType.Xai,
                _ => null,
            };
        }
    }
}