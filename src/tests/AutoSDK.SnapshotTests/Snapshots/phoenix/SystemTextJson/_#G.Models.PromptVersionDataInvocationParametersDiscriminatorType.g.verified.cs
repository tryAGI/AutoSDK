//HintName: G.Models.PromptVersionDataInvocationParametersDiscriminatorType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptVersionDataInvocationParametersDiscriminatorType
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