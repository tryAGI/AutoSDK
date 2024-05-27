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
    [global::System.Runtime.Serialization.DataContract]
    public enum SendChatAnnouncementRequestColor
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="blue")]
        Blue,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="green")]
        Green,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="orange")]
        Orange,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="purple")]
        Purple,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="primary (default)")]
        PrimaryDefault,
    }
}