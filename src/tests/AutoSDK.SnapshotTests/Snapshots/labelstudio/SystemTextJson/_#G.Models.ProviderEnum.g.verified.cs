//HintName: G.Models.ProviderEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `OpenAI` - OpenAI<br/>
    /// * `AzureOpenAI` - AzureOpenAI<br/>
    /// * `AzureAIFoundry` - AzureAIFoundry<br/>
    /// * `VertexAI` - VertexAI<br/>
    /// * `Gemini` - Gemini<br/>
    /// * `Anthropic` - Anthropic<br/>
    /// * `Custom` - Custom
    /// </summary>
    public enum ProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        AzureAIFoundry,
        /// <summary>
        /// 
        /// </summary>
        AzureOpenAI,
        /// <summary>
        /// 
        /// </summary>
        Custom,
        /// <summary>
        /// 
        /// </summary>
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        OpenAI,
        /// <summary>
        /// 
        /// </summary>
        VertexAI,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderEnum value)
        {
            return value switch
            {
                ProviderEnum.Anthropic => "Anthropic",
                ProviderEnum.AzureAIFoundry => "AzureAIFoundry",
                ProviderEnum.AzureOpenAI => "AzureOpenAI",
                ProviderEnum.Custom => "Custom",
                ProviderEnum.Gemini => "Gemini",
                ProviderEnum.OpenAI => "OpenAI",
                ProviderEnum.VertexAI => "VertexAI",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderEnum? ToEnum(string value)
        {
            return value switch
            {
                "Anthropic" => ProviderEnum.Anthropic,
                "AzureAIFoundry" => ProviderEnum.AzureAIFoundry,
                "AzureOpenAI" => ProviderEnum.AzureOpenAI,
                "Custom" => ProviderEnum.Custom,
                "Gemini" => ProviderEnum.Gemini,
                "OpenAI" => ProviderEnum.OpenAI,
                "VertexAI" => ProviderEnum.VertexAI,
                _ => null,
            };
        }
    }
}