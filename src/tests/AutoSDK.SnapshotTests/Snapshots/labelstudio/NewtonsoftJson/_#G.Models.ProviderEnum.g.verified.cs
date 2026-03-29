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
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderEnum
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AzureAIFoundry")]
        AzureAIFoundry,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="AzureOpenAI")]
        AzureOpenAI,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Custom")]
        Custom,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Gemini")]
        Gemini,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="OpenAI")]
        OpenAI,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="VertexAI")]
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