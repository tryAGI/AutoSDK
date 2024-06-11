//HintName: G.Models.SendExtensionPubSubMessageBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SendExtensionPubSubMessageBody
    {
        /// <summary>
        /// The target of the message. Possible values are:  
        ///   
        /// * broadcast
        /// * global
        /// * whisper-&lt;user-id&gt;
        ///   
        /// If `is_global_broadcast` is **true**, you must set this field to global. The broadcast and global values are mutually exclusive; specify only one of them.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("target", Required = global::Newtonsoft.Json.Required.Always)]
        public global::System.Collections.Generic.IList<global::G.SendExtensionPubSubMessageBodyTarget> Target { get; set; } = default!;

        /// <summary>
        /// The ID of the broadcaster to send the message to. Don’t include this field if `is_global_broadcast` is set to **true**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("broadcaster_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BroadcasterId { get; set; } = default!;

        /// <summary>
        /// A Boolean value that determines whether the message should be sent to all channels where your extension is active. Set to **true** if the message should be sent to all channels. The default is **false**.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("is_global_broadcast")]
        public bool IsGlobalBroadcast { get; set; }

        /// <summary>
        /// The message to send. The message can be a plain-text string or a string-encoded JSON object. The message is limited to a maximum of 5 KB.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("message", Required = global::Newtonsoft.Json.Required.Always)]
        public string Message { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}