//HintName: G.Models.UpdateConversationModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UpdateConversationModelSettingsVariant1DiscriminatorProviderType
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
    public static class UpdateConversationModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateConversationModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateConversationModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => UpdateConversationModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}