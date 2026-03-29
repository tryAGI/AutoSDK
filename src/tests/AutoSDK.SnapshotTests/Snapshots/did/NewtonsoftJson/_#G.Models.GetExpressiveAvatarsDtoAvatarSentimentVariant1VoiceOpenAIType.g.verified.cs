//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType
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
    public static class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAITypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType value)
        {
            return value switch
            {
                GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType.AzureOpenai => "azure-openai",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType? ToEnum(string value)
        {
            return value switch
            {
                "azure-openai" => GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceOpenAIType.AzureOpenai,
                _ => null,
            };
        }
    }
}