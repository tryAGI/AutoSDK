//HintName: G.Models.CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType
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
    public static class CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => CompactionSettingsOutputModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}