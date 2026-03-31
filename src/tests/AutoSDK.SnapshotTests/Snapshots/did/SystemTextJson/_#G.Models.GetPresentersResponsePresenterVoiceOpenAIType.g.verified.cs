//HintName: G.Models.GetPresentersResponsePresenterVoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetPresentersResponsePresenterVoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPresentersResponsePresenterVoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPresentersResponsePresenterVoiceOpenAIType value)
        {
            return value switch
            {
                GetPresentersResponsePresenterVoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPresentersResponsePresenterVoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => GetPresentersResponsePresenterVoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}