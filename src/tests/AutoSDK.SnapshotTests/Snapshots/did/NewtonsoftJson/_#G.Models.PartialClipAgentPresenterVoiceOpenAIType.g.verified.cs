//HintName: G.Models.PartialClipAgentPresenterVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialClipAgentPresenterVoiceOpenAIType
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
    public static class PartialClipAgentPresenterVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialClipAgentPresenterVoiceOpenAIType value)
        {
            return value switch
            {
                PartialClipAgentPresenterVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialClipAgentPresenterVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => PartialClipAgentPresenterVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}