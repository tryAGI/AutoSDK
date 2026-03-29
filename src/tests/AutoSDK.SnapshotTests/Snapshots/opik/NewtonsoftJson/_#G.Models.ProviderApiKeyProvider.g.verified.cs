//HintName: G.Models.ProviderApiKeyProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderApiKeyProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="custom-llm")]
        CustomLlm,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="gemini")]
        Gemini,
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
        [global::System.Runtime.Serialization.EnumMember(Value="openrouter")]
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="opik-free")]
        OpikFree,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="vertex-ai")]
        VertexAi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProviderApiKeyProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderApiKeyProvider value)
        {
            return value switch
            {
                ProviderApiKeyProvider.Anthropic => "anthropic",
                ProviderApiKeyProvider.Bedrock => "bedrock",
                ProviderApiKeyProvider.CustomLlm => "custom-llm",
                ProviderApiKeyProvider.Gemini => "gemini",
                ProviderApiKeyProvider.Ollama => "ollama",
                ProviderApiKeyProvider.Openai => "openai",
                ProviderApiKeyProvider.Openrouter => "openrouter",
                ProviderApiKeyProvider.OpikFree => "opik-free",
                ProviderApiKeyProvider.VertexAi => "vertex-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderApiKeyProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ProviderApiKeyProvider.Anthropic,
                "bedrock" => ProviderApiKeyProvider.Bedrock,
                "custom-llm" => ProviderApiKeyProvider.CustomLlm,
                "gemini" => ProviderApiKeyProvider.Gemini,
                "ollama" => ProviderApiKeyProvider.Ollama,
                "openai" => ProviderApiKeyProvider.Openai,
                "openrouter" => ProviderApiKeyProvider.Openrouter,
                "opik-free" => ProviderApiKeyProvider.OpikFree,
                "vertex-ai" => ProviderApiKeyProvider.VertexAi,
                _ => null,
            };
        }
    }
}