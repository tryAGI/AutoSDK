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
}