//HintName: G.Models.SendChatAnnouncementBodyColor.g.cs

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
    public enum SendChatAnnouncementBodyColor
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

    public static class SendChatAnnouncementBodyColorExtensions
    {
        public static string ToValueString(this SendChatAnnouncementBodyColor value)
        {
            return value switch
            {
                SendChatAnnouncementBodyColor.Blue => "blue",
                SendChatAnnouncementBodyColor.Green => "green",
                SendChatAnnouncementBodyColor.Orange => "orange",
                SendChatAnnouncementBodyColor.Purple => "purple",
                SendChatAnnouncementBodyColor.PrimaryDefault => "primary (default)",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SendChatAnnouncementBodyColor ToEnum(string value)
        {
            return value switch
            {
                "blue" => SendChatAnnouncementBodyColor.Blue,
                "green" => SendChatAnnouncementBodyColor.Green,
                "orange" => SendChatAnnouncementBodyColor.Orange,
                "purple" => SendChatAnnouncementBodyColor.Purple,
                "primary (default)" => SendChatAnnouncementBodyColor.PrimaryDefault,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        public static SendChatAnnouncementBodyColor ToEnum(int value)
        {
            return value switch
            {
                0 => SendChatAnnouncementBodyColor.Blue,
                1 => SendChatAnnouncementBodyColor.Green,
                2 => SendChatAnnouncementBodyColor.Orange,
                3 => SendChatAnnouncementBodyColor.Purple,
                4 => SendChatAnnouncementBodyColor.PrimaryDefault,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}