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
    public abstract class UserBroadcasterType
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Affiliate = "affiliate";
        /// <summary>
        /// 
        /// </summary>
        public const string Partner = "partner";
    }
}