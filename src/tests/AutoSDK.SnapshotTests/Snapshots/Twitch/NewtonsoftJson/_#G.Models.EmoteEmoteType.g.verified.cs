//HintName: G.Models.EmoteEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:   <br/>
    ///   <br/>
    /// * bitstier — A Bits tier emote.<br/>
    /// * follower — A follower emote.<br/>
    /// * subscriptions — A subscriber emote.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum EmoteEmoteType
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
        public static EmoteEmoteType? ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => EmoteEmoteType.Bitstier,
                "follower" => EmoteEmoteType.Follower,
                "subscriptions" => EmoteEmoteType.Subscriptions,
                _ => null,
            };
        }
    }
}