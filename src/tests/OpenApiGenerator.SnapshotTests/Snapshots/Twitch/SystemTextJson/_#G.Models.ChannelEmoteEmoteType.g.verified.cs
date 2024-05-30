//HintName: G.Models.ChannelEmoteEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:  
    ///   
    /// * bitstier — A custom Bits tier emote.
    /// * follower — A custom follower emote.
    /// * subscriptions — A custom subscriber emote.
    /// </summary>
    public enum ChannelEmoteEmoteType
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
    public static class ChannelEmoteEmoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChannelEmoteEmoteType value)
        {
            return value switch
            {
                ChannelEmoteEmoteType.Bitstier => "bitstier",
                ChannelEmoteEmoteType.Follower => "follower",
                ChannelEmoteEmoteType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChannelEmoteEmoteType ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => ChannelEmoteEmoteType.Bitstier,
                "follower" => ChannelEmoteEmoteType.Follower,
                "subscriptions" => ChannelEmoteEmoteType.Subscriptions,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}