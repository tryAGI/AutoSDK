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
    [global::System.Runtime.Serialization.DataContract]
    public enum ChannelEmoteEmoteType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="bitstier")]
        Bitstier,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="follower")]
        Follower,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="subscriptions")]
        Subscriptions,
    }

    public static class ChannelEmoteEmoteTypeExtensions
    {
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
        public static ChannelEmoteEmoteType ToEnum(int value)
        {
            return value switch
            {
                0 => ChannelEmoteEmoteType.Bitstier,
                1 => ChannelEmoteEmoteType.Follower,
                2 => ChannelEmoteEmoteType.Subscriptions,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}