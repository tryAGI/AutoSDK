//HintName: G.Models.ConversationModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ConversationModelSettingsVariant1DiscriminatorProviderType
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
    public static class ConversationModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                ConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                ConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                ConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                ConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                ConversationModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => ConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => ConversationModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => ConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => ConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => ConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => ConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => ConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => ConversationModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => ConversationModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => ConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => ConversationModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => ConversationModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => ConversationModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}