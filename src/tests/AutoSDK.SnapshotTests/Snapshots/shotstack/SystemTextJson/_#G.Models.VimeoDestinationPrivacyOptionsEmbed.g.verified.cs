//HintName: G.Models.VimeoDestinationPrivacyOptionsEmbed.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set who can embed the video. Available options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`public` - Anyone can embed the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`private` - Only the video owner can embed the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`whitelist` - Only whitelisted domains can embed the video.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    public enum VimeoDestinationPrivacyOptionsEmbed
    {
        /// <summary>
        /// 
        /// </summary>
        Private,
        /// <summary>
        /// 
        /// </summary>
        Public,
        /// <summary>
        /// 
        /// </summary>
        Whitelist,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VimeoDestinationPrivacyOptionsEmbedExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VimeoDestinationPrivacyOptionsEmbed value)
        {
            return value switch
            {
                VimeoDestinationPrivacyOptionsEmbed.Private => "private",
                VimeoDestinationPrivacyOptionsEmbed.Public => "public",
                VimeoDestinationPrivacyOptionsEmbed.Whitelist => "whitelist",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VimeoDestinationPrivacyOptionsEmbed? ToEnum(string value)
        {
            return value switch
            {
                "private" => VimeoDestinationPrivacyOptionsEmbed.Private,
                "public" => VimeoDestinationPrivacyOptionsEmbed.Public,
                "whitelist" => VimeoDestinationPrivacyOptionsEmbed.Whitelist,
                _ => null,
            };
        }
    }
}