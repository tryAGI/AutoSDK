//HintName: G.Models.UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="azure-openai")]
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => UpdateResponseVariant1PresenterPhotoAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}