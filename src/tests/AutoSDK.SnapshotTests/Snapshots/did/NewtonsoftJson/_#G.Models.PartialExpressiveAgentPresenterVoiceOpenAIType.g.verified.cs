//HintName: G.Models.PartialExpressiveAgentPresenterVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PartialExpressiveAgentPresenterVoiceOpenAIType
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
    public static class PartialExpressiveAgentPresenterVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PartialExpressiveAgentPresenterVoiceOpenAIType value)
        {
            return value switch
            {
                PartialExpressiveAgentPresenterVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PartialExpressiveAgentPresenterVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => PartialExpressiveAgentPresenterVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}