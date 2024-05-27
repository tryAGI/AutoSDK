//HintName: G.Models.UserBroadcasterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of broadcaster. Possible values are:  
    ///   
    /// * affiliate — An [affiliate broadcaster](https://help.twitch.tv/s/article/joining-the-affiliate-program)
    /// * partner — A [partner broadcaster](https://help.twitch.tv/s/article/partner-program-overview)
    /// * "" — A normal broadcaster
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum UserBroadcasterType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="affiliate")]
        Affiliate,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="partner")]
        Partner,
    }
}