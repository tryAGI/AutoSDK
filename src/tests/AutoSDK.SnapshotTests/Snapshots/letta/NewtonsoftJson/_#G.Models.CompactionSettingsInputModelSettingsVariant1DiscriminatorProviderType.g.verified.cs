//HintName: G.Models.CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anthropic")]
        Anthropic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure")]
        Azure,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bedrock")]
        Bedrock,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="chatgpt_oauth")]
        ChatgptOauth,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="deepseek")]
        Deepseek,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google_ai")]
        GoogleAi,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="google_vertex")]
        GoogleVertex,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="groq")]
        Groq,
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
        [global::System.Runtime.Serialization.EnumMember(Value="together")]
        Together,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="xai")]
        Xai,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="zai")]
        Zai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => CompactionSettingsInputModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}