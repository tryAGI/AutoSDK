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
}