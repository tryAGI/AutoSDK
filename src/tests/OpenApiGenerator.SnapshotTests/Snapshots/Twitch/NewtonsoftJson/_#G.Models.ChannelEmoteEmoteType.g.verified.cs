//HintName: G.Models.ChannelEmoteEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:  <br/>
    ///   <br/>
    /// * bitstier — A custom Bits tier emote.<br/>
    /// * follower — A custom follower emote.<br/>
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
        public static ChannelEmoteEmoteType? ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => ChannelEmoteEmoteType.Bitstier,
                "follower" => ChannelEmoteEmoteType.Follower,
                "subscriptions" => ChannelEmoteEmoteType.Subscriptions,
                _ => null,
            };
        }
    }
}