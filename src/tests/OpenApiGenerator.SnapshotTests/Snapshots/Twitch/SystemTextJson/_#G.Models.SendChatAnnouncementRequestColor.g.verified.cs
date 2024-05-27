//HintName: G.Models.SendChatAnnouncementRequestColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The color used to highlight the announcement. Possible case-sensitive values are:  
    ///   
    /// * blue
    /// * green
    /// * orange
    /// * purple
    /// * primary (default)
    ///   
    /// If `color` is set to _primary_ or is not set, the channel’s accent color is used to highlight the announcement (see **Profile Accent Color** under [profile settings](https://www.twitch.tv/settings/profile), **Channel and Videos**, and **Brand**).
    /// </summary>
    public abstract class SendChatAnnouncementRequestColor
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Blue = "blue";
        /// <summary>
        /// 
        /// </summary>
        public const string Green = "green";
        /// <summary>
        /// 
        /// </summary>
        public const string Orange = "orange";
        /// <summary>
        /// 
        /// </summary>
        public const string Purple = "purple";
        /// <summary>
        /// 
        /// </summary>
        public const string PrimaryDefault = "primary (default)";
    }
}