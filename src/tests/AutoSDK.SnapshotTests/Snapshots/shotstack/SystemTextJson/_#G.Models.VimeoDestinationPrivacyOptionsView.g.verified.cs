//HintName: G.Models.VimeoDestinationPrivacyOptionsView.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set who can view the videos. Available options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`anybody` - Anyone can view the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`nobody` - Only the video owner can view the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`contacts` - Only contacts can view the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`password` - A password is required to view the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`unlisted` - The video is not listed on Vimeo.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum VimeoDestinationPrivacyOptionsView
    {
        /// <summary>
        /// 
        /// </summary>
        Anybody,
        /// <summary>
        /// 
        /// </summary>
        Contacts,
        /// <summary>
        /// 
        /// </summary>
        Nobody,
        /// <summary>
        /// 
        /// </summary>
        Password,
        /// <summary>
        /// 
        /// </summary>
        Unlisted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VimeoDestinationPrivacyOptionsViewExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VimeoDestinationPrivacyOptionsView value)
        {
            return value switch
            {
                VimeoDestinationPrivacyOptionsView.Anybody => "anybody",
                VimeoDestinationPrivacyOptionsView.Contacts => "contacts",
                VimeoDestinationPrivacyOptionsView.Nobody => "nobody",
                VimeoDestinationPrivacyOptionsView.Password => "password",
                VimeoDestinationPrivacyOptionsView.Unlisted => "unlisted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VimeoDestinationPrivacyOptionsView? ToEnum(string value)
        {
            return value switch
            {
                "anybody" => VimeoDestinationPrivacyOptionsView.Anybody,
                "contacts" => VimeoDestinationPrivacyOptionsView.Contacts,
                "nobody" => VimeoDestinationPrivacyOptionsView.Nobody,
                "password" => VimeoDestinationPrivacyOptionsView.Password,
                "unlisted" => VimeoDestinationPrivacyOptionsView.Unlisted,
                _ => null,
            };
        }
    }
}