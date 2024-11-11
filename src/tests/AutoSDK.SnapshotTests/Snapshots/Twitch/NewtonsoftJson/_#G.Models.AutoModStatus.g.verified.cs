//HintName: G.Models.AutoModStatus.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AutoModStatus
    {
        /// <summary>
        /// The caller-defined ID passed in the request.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MsgId { get; set; } = default!;

        /// <summary>
        /// A Boolean value that indicates whether Twitch would approve the message for chat or hold it for moderator review or block it from chat. Is **true** if Twitch would approve the message; otherwise, **false** if Twitch would hold the message for moderator review or block it from chat.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_permitted", Required = global::Newtonsoft.Json.Required.Always)]
        public bool IsPermitted { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModStatus" /> class.
        /// </summary>
        /// <param name="msgId">
        /// The caller-defined ID passed in the request.
        /// </param>
        /// <param name="isPermitted">
        /// A Boolean value that indicates whether Twitch would approve the message for chat or hold it for moderator review or block it from chat. Is **true** if Twitch would approve the message; otherwise, **false** if Twitch would hold the message for moderator review or block it from chat.
        /// </param>
        public AutoModStatus(
            string msgId,
            bool isPermitted)
        {
            this.MsgId = msgId ?? throw new global::System.ArgumentNullException(nameof(msgId));
            this.IsPermitted = isPermitted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoModStatus" /> class.
        /// </summary>
        public AutoModStatus()
        {
        }
    }
}