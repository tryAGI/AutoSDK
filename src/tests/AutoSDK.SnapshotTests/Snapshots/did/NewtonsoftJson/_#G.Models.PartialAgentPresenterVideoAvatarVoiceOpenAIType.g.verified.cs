//HintName: G.Models.PartialAgentPresenterVideoAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentPresenterVideoAvatarVoiceOpenAIType
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
    public static class PartialAgentPresenterVideoAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentPresenterVideoAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                PartialAgentPresenterVideoAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentPresenterVideoAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => PartialAgentPresenterVideoAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}