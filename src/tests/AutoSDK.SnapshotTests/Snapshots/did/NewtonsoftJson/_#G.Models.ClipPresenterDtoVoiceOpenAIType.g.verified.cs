//HintName: G.Models.ClipPresenterDtoVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ClipPresenterDtoVoiceOpenAIType
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
    public static class ClipPresenterDtoVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ClipPresenterDtoVoiceOpenAIType value)
        {
            return value switch
            {
                ClipPresenterDtoVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ClipPresenterDtoVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => ClipPresenterDtoVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}