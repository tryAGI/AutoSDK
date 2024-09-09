//HintName: G.Models.UserBroadcasterType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The type of broadcaster. Possible values are:  <br/>
    ///   <br/>
    /// * affiliate — An [affiliate broadcaster](https://help.twitch.tv/s/article/joining-the-affiliate-program)<br/>
    /// * partner — A [partner broadcaster](https://help.twitch.tv/s/article/partner-program-overview)<br/>
    /// * "" — A normal broadcaster
    /// </summary>
    public enum UserBroadcasterType
    {
        /// <summary>
        /// 
        /// </summary>
        Affiliate,
        /// <summary>
        /// 
        /// </summary>
        Partner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserBroadcasterTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserBroadcasterType value)
        {
            return value switch
            {
                UserBroadcasterType.Affiliate => "affiliate",
                UserBroadcasterType.Partner => "partner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserBroadcasterType? ToEnum(string value)
        {
            return value switch
            {
                "affiliate" => UserBroadcasterType.Affiliate,
                "partner" => UserBroadcasterType.Partner,
                _ => null,
            };
        }
    }
}