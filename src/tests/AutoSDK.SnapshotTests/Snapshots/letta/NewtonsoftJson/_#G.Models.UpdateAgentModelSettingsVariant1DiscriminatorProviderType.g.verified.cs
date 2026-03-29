//HintName: G.Models.UpdateAgentModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateAgentModelSettingsVariant1DiscriminatorProviderType
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
    public static class UpdateAgentModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateAgentModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateAgentModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => UpdateAgentModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}