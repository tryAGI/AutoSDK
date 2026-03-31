//HintName: G.Models.GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType
    {
        /// <summary>
        /// 
        /// </summary>
        AzureOpenai,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType value)
        {
            return value switch
            {
                GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => GetAvatars1ResponseAvatarSentimentVariant1VoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}