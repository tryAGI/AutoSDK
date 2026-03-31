//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatarByIdResponseSentimentVariant1VoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => GetAvatarByIdResponseSentimentVariant1VoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}