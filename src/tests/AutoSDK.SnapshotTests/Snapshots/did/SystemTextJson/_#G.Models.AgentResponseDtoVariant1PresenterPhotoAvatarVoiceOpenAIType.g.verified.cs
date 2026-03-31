//HintName: G.Models.AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AgentResponseDtoVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}