//HintName: G.Models.EmoteEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:   
    ///   
    /// * bitstier — A Bits tier emote.
    /// * follower — A follower emote.
    /// * subscriptions — A subscriber emote.
    /// </summary>
    public enum EmoteEmoteType
    {
        /// <summary>
        /// 
        /// </summary>
        Bitstier,
        /// <summary>
        /// 
        /// </summary>
        Follower,
        /// <summary>
        /// 
        /// </summary>
        Subscriptions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmoteEmoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmoteEmoteType value)
        {
            return value switch
            {
                EmoteEmoteType.Bitstier => "bitstier",
                EmoteEmoteType.Follower => "follower",
                EmoteEmoteType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmoteEmoteType ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => EmoteEmoteType.Bitstier,
                "follower" => EmoteEmoteType.Follower,
                "subscriptions" => EmoteEmoteType.Subscriptions,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}