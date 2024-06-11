//HintName: G.Models.ManageHeldAutoModMessagesBody.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ManageHeldAutoModMessagesBody
    {
        /// <summary>
        /// The moderator who is approving or denying the held message. This ID must match the user ID in the access token.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// The ID of the message to allow or deny.
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("msg_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string MsgId { get; set; } = default!;

        /// <summary>
        /// The action to take for the message. Possible values are:  
        ///   
        /// * ALLOW
        /// * DENY
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("action", Required = global::Newtonsoft.Json.Required.Always)]
        public global::G.ManageHeldAutoModMessagesBodyAction Action { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}