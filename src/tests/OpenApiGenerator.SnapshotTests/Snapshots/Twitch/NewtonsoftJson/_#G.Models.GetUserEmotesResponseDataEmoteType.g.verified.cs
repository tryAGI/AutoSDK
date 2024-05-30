//HintName: G.Models.GetUserEmotesResponseDataEmoteType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of emote. The possible values are:   
    ///   
    /// * **bitstier** — A Bits tier emote.
    /// * **follower** — A follower emote.
    /// * **subscriptions** — A subscriber emote.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GetUserEmotesResponseDataEmoteType
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
    public static class GetUserEmotesResponseDataEmoteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetUserEmotesResponseDataEmoteType value)
        {
            return value switch
            {
                GetUserEmotesResponseDataEmoteType.Bitstier => "bitstier",
                GetUserEmotesResponseDataEmoteType.Follower => "follower",
                GetUserEmotesResponseDataEmoteType.Subscriptions => "subscriptions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetUserEmotesResponseDataEmoteType ToEnum(string value)
        {
            return value switch
            {
                "bitstier" => GetUserEmotesResponseDataEmoteType.Bitstier,
                "follower" => GetUserEmotesResponseDataEmoteType.Follower,
                "subscriptions" => GetUserEmotesResponseDataEmoteType.Subscriptions,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}