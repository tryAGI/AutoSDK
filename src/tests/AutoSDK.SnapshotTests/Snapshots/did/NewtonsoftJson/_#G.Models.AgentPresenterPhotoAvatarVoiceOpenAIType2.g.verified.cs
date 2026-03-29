//HintName: G.Models.AgentPresenterPhotoAvatarVoiceOpenAIType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum AgentPresenterPhotoAvatarVoiceOpenAIType2
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
    public static class AgentPresenterPhotoAvatarVoiceOpenAIType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentPresenterPhotoAvatarVoiceOpenAIType2 value)
        {
            return value switch
            {
                AgentPresenterPhotoAvatarVoiceOpenAIType2.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentPresenterPhotoAvatarVoiceOpenAIType2? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => AgentPresenterPhotoAvatarVoiceOpenAIType2.AzureOpenai,
                _ => null,
            };
        }
    }
}