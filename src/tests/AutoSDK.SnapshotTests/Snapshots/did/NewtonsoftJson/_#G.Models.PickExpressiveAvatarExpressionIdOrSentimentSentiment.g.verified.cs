//HintName: G.Models.PickExpressiveAvatarExpressionIdOrSentimentSentiment.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The sentiment of the avatar's expression<br/>
    /// Example: happy
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PickExpressiveAvatarExpressionIdOrSentimentSentiment
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
    public static class PickExpressiveAvatarExpressionIdOrSentimentSentimentExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PickExpressiveAvatarExpressionIdOrSentimentSentiment value)
        {
            return value switch
            {
                PickExpressiveAvatarExpressionIdOrSentimentSentiment.Empathetic => "Empathetic",
                PickExpressiveAvatarExpressionIdOrSentimentSentiment.Excited => "Excited",
                PickExpressiveAvatarExpressionIdOrSentimentSentiment.Friendly => "Friendly",
                PickExpressiveAvatarExpressionIdOrSentimentSentiment.Frustrated => "Frustrated",
                PickExpressiveAvatarExpressionIdOrSentimentSentiment.Professional => "Professional",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PickExpressiveAvatarExpressionIdOrSentimentSentiment? ToEnum(string value)
        {
            return value switch
            {
                "Empathetic" => PickExpressiveAvatarExpressionIdOrSentimentSentiment.Empathetic,
                "Excited" => PickExpressiveAvatarExpressionIdOrSentimentSentiment.Excited,
                "Friendly" => PickExpressiveAvatarExpressionIdOrSentimentSentiment.Friendly,
                "Frustrated" => PickExpressiveAvatarExpressionIdOrSentimentSentiment.Frustrated,
                "Professional" => PickExpressiveAvatarExpressionIdOrSentimentSentiment.Professional,
                _ => null,
            };
        }
    }
}