//HintName: G.Models.CreateConversationModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateConversationModelSettingsVariant1DiscriminatorProviderType
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
    public static class CreateConversationModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateConversationModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                CreateConversationModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateConversationModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => CreateConversationModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}