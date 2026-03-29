//HintName: G.Models.GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType
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
    public static class GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType value)
        {
            return value switch
            {
                GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType.Microsoft => "microsoft",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType? ToEnum(string value)
        {
            return value switch
            {
                "microsoft" => GetAvatarByIdResponseSentimentVariant1VoiceMicrosoftType.Microsoft,
                _ => null,
            };
        }
    }
}