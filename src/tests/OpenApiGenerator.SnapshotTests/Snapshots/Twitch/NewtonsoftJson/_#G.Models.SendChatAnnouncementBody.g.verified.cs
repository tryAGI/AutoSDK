//HintName: G.Models.SendChatAnnouncementBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendChatAnnouncementBody
    {
        /// <summary>
        /// The announcement to make in the broadcaster’s chat room. Announcements are limited to a maximum of 500 characters; announcements longer than 500 characters are truncated.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

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
        [global::Newtonsoft.Json.JsonProperty("color")]
        public global::G.SendChatAnnouncementBodyColor? Color { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}