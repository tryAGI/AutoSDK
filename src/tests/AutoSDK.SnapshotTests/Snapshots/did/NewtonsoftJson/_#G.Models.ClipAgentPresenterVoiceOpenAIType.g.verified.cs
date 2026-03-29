//HintName: G.Models.ClipAgentPresenterVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipAgentPresenterVoiceOpenAIType
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
    public static class ClipAgentPresenterVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipAgentPresenterVoiceOpenAIType value)
        {
            return value switch
            {
                ClipAgentPresenterVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipAgentPresenterVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ClipAgentPresenterVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}