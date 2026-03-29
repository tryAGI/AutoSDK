//HintName: G.Models.InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType
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
    public static class InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => InternalTemplateAgentCreateModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}