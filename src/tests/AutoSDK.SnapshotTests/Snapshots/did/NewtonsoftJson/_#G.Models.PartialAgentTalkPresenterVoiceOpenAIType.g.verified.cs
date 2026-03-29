//HintName: G.Models.PartialAgentTalkPresenterVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialAgentTalkPresenterVoiceOpenAIType
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
    public static class PartialAgentTalkPresenterVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialAgentTalkPresenterVoiceOpenAIType value)
        {
            return value switch
            {
                PartialAgentTalkPresenterVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialAgentTalkPresenterVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => PartialAgentTalkPresenterVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}