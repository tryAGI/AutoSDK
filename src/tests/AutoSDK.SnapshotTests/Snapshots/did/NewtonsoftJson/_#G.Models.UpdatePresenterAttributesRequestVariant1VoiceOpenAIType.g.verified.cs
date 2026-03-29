//HintName: G.Models.UpdatePresenterAttributesRequestVariant1VoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UpdatePresenterAttributesRequestVariant1VoiceOpenAIType
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
    public static class UpdatePresenterAttributesRequestVariant1VoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdatePresenterAttributesRequestVariant1VoiceOpenAIType value)
        {
            return value switch
            {
                UpdatePresenterAttributesRequestVariant1VoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdatePresenterAttributesRequestVariant1VoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => UpdatePresenterAttributesRequestVariant1VoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}