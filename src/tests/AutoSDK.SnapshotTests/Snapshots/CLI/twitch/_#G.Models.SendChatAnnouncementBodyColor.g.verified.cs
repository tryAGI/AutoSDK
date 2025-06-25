//HintName: G.Models.SendChatAnnouncementBodyColor.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The color used to highlight the announcement. Possible case-sensitive values are:  <br/>
    ///   <br/>
    /// * blue<br/>
    /// * green<br/>
    /// * orange<br/>
    /// * purple<br/>
    /// * primary (default)<br/>
    ///   <br/>
    /// If `color` is set to _primary_ or is not set, the channel’s accent color is used to highlight the announcement (see **Profile Accent Color** under [profile settings](https://www.twitch.tv/settings/profile), **Channel and Videos**, and **Brand**).
    /// </summary>
    public enum SendChatAnnouncementBodyColor
    {
        /// <summary>
        /// 
        /// </summary>
        Blue,
        /// <summary>
        /// 
        /// </summary>
        Green,
        /// <summary>
        /// 
        /// </summary>
        Orange,
        /// <summary>
        /// 
        /// </summary>
        Purple,
        /// <summary>
        /// 
        /// </summary>
        PrimaryDefault,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendChatAnnouncementBodyColorExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
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
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendChatAnnouncementBodyColor? ToEnum(string value)
        {
            return value switch
            {
                "blue" => SendChatAnnouncementBodyColor.Blue,
                "green" => SendChatAnnouncementBodyColor.Green,
                "orange" => SendChatAnnouncementBodyColor.Orange,
                "purple" => SendChatAnnouncementBodyColor.Purple,
                "primary (default)" => SendChatAnnouncementBodyColor.PrimaryDefault,
                _ => null,
            };
        }
    }
}