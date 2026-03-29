//HintName: G.Models.PromptVersionInvocationParametersDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionInvocationParametersDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Aws,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
        /// <summary>
        /// 
        /// </summary>
        Cerebras,
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
        Google,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Moonshot,
        /// <summary>
        /// 
        /// </summary>
        Ollama,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Perplexity,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
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