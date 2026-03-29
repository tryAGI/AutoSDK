//HintName: G.Models.ProviderApiKeyPublicProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ProviderApiKeyPublicProvider
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
    public static class ProviderApiKeyPublicProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProviderApiKeyPublicProvider value)
        {
            return value switch
            {
                ProviderApiKeyPublicProvider.Anthropic => "anthropic",
                ProviderApiKeyPublicProvider.Bedrock => "bedrock",
                ProviderApiKeyPublicProvider.CustomLlm => "custom-llm",
                ProviderApiKeyPublicProvider.Gemini => "gemini",
                ProviderApiKeyPublicProvider.Ollama => "ollama",
                ProviderApiKeyPublicProvider.Openai => "openai",
                ProviderApiKeyPublicProvider.Openrouter => "openrouter",
                ProviderApiKeyPublicProvider.OpikFree => "opik-free",
                ProviderApiKeyPublicProvider.VertexAi => "vertex-ai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProviderApiKeyPublicProvider? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ProviderApiKeyPublicProvider.Anthropic,
                "bedrock" => ProviderApiKeyPublicProvider.Bedrock,
                "custom-llm" => ProviderApiKeyPublicProvider.CustomLlm,
                "gemini" => ProviderApiKeyPublicProvider.Gemini,
                "ollama" => ProviderApiKeyPublicProvider.Ollama,
                "openai" => ProviderApiKeyPublicProvider.Openai,
                "openrouter" => ProviderApiKeyPublicProvider.Openrouter,
                "opik-free" => ProviderApiKeyPublicProvider.OpikFree,
                "vertex-ai" => ProviderApiKeyPublicProvider.VertexAi,
                _ => null,
            };
        }
    }
}