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
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// The ID of the message to allow or deny.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msg_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MsgId { get; set; }

        /// <summary>
        /// The action to take for the message. Possible values are:  <br/>
        ///   <br/>
        /// * ALLOW<br/>
        /// * DENY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.ManageHeldAutoModMessagesBodyActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::G.ManageHeldAutoModMessagesBodyAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageHeldAutoModMessagesBody" /> class.
        /// </summary>
        /// <param name="userId">
        /// The moderator who is approving or denying the held message. This ID must match the user ID in the access token.
        /// </param>
        /// <param name="msgId">
        /// The ID of the message to allow or deny.
        /// </param>
        /// <param name="action">
        /// The action to take for the message. Possible values are:  <br/>
        ///   <br/>
        /// * ALLOW<br/>
        /// * DENY
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ManageHeldAutoModMessagesBody(
            string userId,
            string msgId,
            global::G.ManageHeldAutoModMessagesBodyAction action)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.MsgId = msgId ?? throw new global::System.ArgumentNullException(nameof(msgId));
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ManageHeldAutoModMessagesBody" /> class.
        /// </summary>
        public ManageHeldAutoModMessagesBody()
        {
        }
    }
}