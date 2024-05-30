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

    public static class EmoteEmoteTypeExtensions
    {
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
        public static EmoteEmoteType ToEnum(int value)
        {
            return value switch
            {
                0 => EmoteEmoteType.Bitstier,
                1 => EmoteEmoteType.Follower,
                2 => EmoteEmoteType.Subscriptions,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}