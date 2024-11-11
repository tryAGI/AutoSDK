//HintName: G.Models.MessageSenderProfile.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// MessageSenderProfile describes the public data of a message sender.<br/>
    /// refer to core.mgmt.v1beta.UserProfile for more details.
    /// </summary>
    public sealed partial class MessageSenderProfile
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msgSenderUid")]
        public string? MsgSenderUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msgSenderId")]
        public string? MsgSenderId { get; set; }

        /// <summary>
        /// Display name.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Avatar url. this url might be expired or not exist.<br/>
        /// Included only in responses
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("avatar")]
        public string? Avatar { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSenderProfile" /> class.
        /// </summary>
        /// <param name="msgSenderUid">
        /// Included only in responses
        /// </param>
        /// <param name="msgSenderId">
        /// Included only in responses
        /// </param>
        /// <param name="displayName">
        /// Display name.<br/>
        /// Included only in responses
        /// </param>
        /// <param name="avatar">
        /// Avatar url. this url might be expired or not exist.<br/>
        /// Included only in responses
        /// </param>
        public MessageSenderProfile(
            string? msgSenderUid,
            string? msgSenderId,
            string? displayName,
            string? avatar)
        {
            this.MsgSenderUid = msgSenderUid;
            this.MsgSenderId = msgSenderId;
            this.DisplayName = displayName;
            this.Avatar = avatar;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageSenderProfile" /> class.
        /// </summary>
        public MessageSenderProfile()
        {
        }
    }
}