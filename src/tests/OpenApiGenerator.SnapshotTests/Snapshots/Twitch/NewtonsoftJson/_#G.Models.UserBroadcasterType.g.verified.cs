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

    public static class UserBroadcasterTypeExtensions
    {
        public static string ToValueString(this UserBroadcasterType value)
        {
            return value switch
            {
                UserBroadcasterType.Affiliate => "affiliate",
                UserBroadcasterType.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UserBroadcasterType ToEnum(string value)
        {
            return value switch
            {
                "affiliate" => UserBroadcasterType.Affiliate,
                "partner" => UserBroadcasterType.Partner,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static UserBroadcasterType ToEnum(int value)
        {
            return value switch
            {
                0 => UserBroadcasterType.Affiliate,
                1 => UserBroadcasterType.Partner,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}