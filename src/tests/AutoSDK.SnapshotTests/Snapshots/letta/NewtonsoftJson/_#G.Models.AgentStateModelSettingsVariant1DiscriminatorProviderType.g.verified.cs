//HintName: G.Models.AgentStateModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentStateModelSettingsVariant1DiscriminatorProviderType
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
    public static class AgentStateModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentStateModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                AgentStateModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentStateModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => AgentStateModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => AgentStateModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => AgentStateModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => AgentStateModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}