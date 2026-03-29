//HintName: G.Models.LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType
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
    public static class LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType value)
        {
            return value switch
            {
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Anthropic => "anthropic",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Azure => "azure",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Bedrock => "bedrock",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth => "chatgpt_oauth",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Deepseek => "deepseek",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.GoogleAi => "google_ai",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.GoogleVertex => "google_vertex",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Groq => "groq",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Openai => "openai",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Openrouter => "openrouter",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Together => "together",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Xai => "xai",
                LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Zai => "zai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType? ToEnum(string value)
        {
            return value switch
            {
                "anthropic" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Anthropic,
                "azure" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Azure,
                "bedrock" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Bedrock,
                "chatgpt_oauth" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.ChatgptOauth,
                "deepseek" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Deepseek,
                "google_ai" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.GoogleAi,
                "google_vertex" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.GoogleVertex,
                "groq" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Groq,
                "openai" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Openai,
                "openrouter" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Openrouter,
                "together" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Together,
                "xai" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Xai,
                "zai" => LettaSchemasAgentFileAgentSchemaModelSettingsVariant1DiscriminatorProviderType.Zai,
                _ => null,
            };
        }
    }
}