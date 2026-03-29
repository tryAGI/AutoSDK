//HintName: G.Models.ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType
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
    public static class ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType value)
        {
            return value switch
            {
                ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ListMyAgentsResponseAgentVariant1PresenterExpressiveAvatarVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}