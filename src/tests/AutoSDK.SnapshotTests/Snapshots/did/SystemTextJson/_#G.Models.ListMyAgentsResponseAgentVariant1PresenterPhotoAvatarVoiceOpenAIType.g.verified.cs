//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ListMyAgentsResponseAgentVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}