//HintName: G.Models.TiktokDestinationOptionsPrivacyLevel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The privacy level for the video. Options are: &lt;ul&gt;<br/>
    ///   &lt;li&gt;`public` - video is visible to everyone&lt;/li&gt;<br/>
    ///   &lt;li&gt;`friends` - video is visible to friends only&lt;/li&gt;<br/>
    ///   &lt;li&gt;`private` - video is only visible to you&lt;/li&gt;<br/>
    /// &lt;/ul&gt;<br/>
    /// Default Value: private
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TiktokDestinationOptionsPrivacyLevel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="friends")]
        Friends,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TiktokDestinationOptionsPrivacyLevelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TiktokDestinationOptionsPrivacyLevel value)
        {
            return value switch
            {
                TiktokDestinationOptionsPrivacyLevel.Friends => "friends",
                TiktokDestinationOptionsPrivacyLevel.Private => "private",
                TiktokDestinationOptionsPrivacyLevel.Public => "public",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TiktokDestinationOptionsPrivacyLevel? ToEnum(string value)
        {
            return value switch
            {
                "friends" => TiktokDestinationOptionsPrivacyLevel.Friends,
                "private" => TiktokDestinationOptionsPrivacyLevel.Private,
                "public" => TiktokDestinationOptionsPrivacyLevel.Public,
                _ => null,
            };
        }
    }
}