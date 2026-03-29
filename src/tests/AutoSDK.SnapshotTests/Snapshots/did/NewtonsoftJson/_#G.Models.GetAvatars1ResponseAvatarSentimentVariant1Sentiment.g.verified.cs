//HintName: G.Models.GetAvatars1ResponseAvatarSentimentVariant1Sentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetAvatars1ResponseAvatarSentimentVariant1Sentiment
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Empathetic")]
        Empathetic,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Excited")]
        Excited,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Friendly")]
        Friendly,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Frustrated")]
        Frustrated,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="Professional")]
        Professional,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetAvatars1ResponseAvatarSentimentVariant1SentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetAvatars1ResponseAvatarSentimentVariant1Sentiment value)
        {
            return value switch
            {
                GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Empathetic => "Empathetic",
                GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Excited => "Excited",
                GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Friendly => "Friendly",
                GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Frustrated => "Frustrated",
                GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetAvatars1ResponseAvatarSentimentVariant1Sentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Empathetic,
                "Excited" => GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Excited,
                "Friendly" => GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Friendly,
                "Frustrated" => GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Frustrated,
                "Professional" => GetAvatars1ResponseAvatarSentimentVariant1Sentiment.Professional,
                _ => null,
            };
        }
    }
}