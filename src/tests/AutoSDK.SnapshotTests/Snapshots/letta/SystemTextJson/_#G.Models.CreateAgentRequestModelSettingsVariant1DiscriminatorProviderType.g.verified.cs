//HintName: G.Models.CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        Azure,
        /// <summary>
        /// 
        /// </summary>
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        ChatgptOauth,
        /// <summary>
        /// 
        /// </summary>
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        GoogleAi,
        /// <summary>
        /// 
        /// </summary>
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        Groq,
        /// <summary>
        /// 
        /// </summary>
        Openai,
        /// <summary>
        /// 
        /// </summary>
        Openrouter,
        /// <summary>
        /// 
        /// </summary>
        Together,
        /// <summary>
        /// 
        /// </summary>
        Xai,
        /// <summary>
        /// 
        /// </summary>
        Zai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateAgentRequestModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => CreateAgentRequestModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}