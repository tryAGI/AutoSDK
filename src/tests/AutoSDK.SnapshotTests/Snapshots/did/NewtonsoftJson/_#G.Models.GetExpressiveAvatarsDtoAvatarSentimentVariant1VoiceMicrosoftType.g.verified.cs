//HintName: G.Models.GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="microsoft")]
        Microsoft,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType value)
        {
            return value switch
            {
                GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => GetExpressiveAvatarsDtoAvatarSentimentVariant1VoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}