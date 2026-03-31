//HintName: G.Models.AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AgentResponseDtoVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}