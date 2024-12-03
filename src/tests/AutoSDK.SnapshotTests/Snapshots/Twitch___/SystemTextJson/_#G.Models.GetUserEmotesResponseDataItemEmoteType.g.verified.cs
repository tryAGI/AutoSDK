//HintName: G.Models.GetUserEmotesResponseDataItemEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:   <br/>
    ///   <br/>
    /// * **bitstier** — A Bits tier emote.<br/>
    /// * **follower** — A follower emote.<br/>
    /// * **subscriptions** — A subscriber emote.
    /// </summary>
    public enum GetUserEmotesResponseDataItemEmoteType
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
    public static class GetUserEmotesResponseDataItemEmoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserEmotesResponseDataItemEmoteType value)
        {
            return value switch
            {
                GetUserEmotesResponseDataItemEmoteType.Bitstier => "bitstier",
                GetUserEmotesResponseDataItemEmoteType.Follower => "follower",
                GetUserEmotesResponseDataItemEmoteType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserEmotesResponseDataItemEmoteType? ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => GetUserEmotesResponseDataItemEmoteType.Bitstier,
                "follower" => GetUserEmotesResponseDataItemEmoteType.Follower,
                "subscriptions" => GetUserEmotesResponseDataItemEmoteType.Subscriptions,
                _ => null,
            };
        }
    }
}