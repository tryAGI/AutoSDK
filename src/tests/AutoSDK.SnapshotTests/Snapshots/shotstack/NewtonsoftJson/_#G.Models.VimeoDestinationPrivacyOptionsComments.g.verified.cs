//HintName: G.Models.VimeoDestinationPrivacyOptionsComments.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Set who can comment on the video. Available options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`anybody` - Anyone can comment on the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`nobody` - Only the video owner can comment on the video.&lt;/li&gt;<br/>
    ///   &lt;li&gt;`contacts` - Only contacts can comment on the video.&lt;/li&gt;<br/>
    /// &lt;/ul&gt;
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum VimeoDestinationPrivacyOptionsComments
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="anybody")]
        Anybody,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="contacts")]
        Contacts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="nobody")]
        Nobody,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class VimeoDestinationPrivacyOptionsCommentsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this VimeoDestinationPrivacyOptionsComments value)
        {
            return value switch
            {
                VimeoDestinationPrivacyOptionsComments.Anybody => "anybody",
                VimeoDestinationPrivacyOptionsComments.Contacts => "contacts",
                VimeoDestinationPrivacyOptionsComments.Nobody => "nobody",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static VimeoDestinationPrivacyOptionsComments? ToEnum(string value)
        {
            return value switch
            {
                "anybody" => VimeoDestinationPrivacyOptionsComments.Anybody,
                "contacts" => VimeoDestinationPrivacyOptionsComments.Contacts,
                "nobody" => VimeoDestinationPrivacyOptionsComments.Nobody,
                _ => null,
            };
        }
    }
}