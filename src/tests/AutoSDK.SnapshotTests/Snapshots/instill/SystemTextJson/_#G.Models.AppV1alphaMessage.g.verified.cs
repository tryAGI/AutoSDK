//HintName: G.Models.AppV1alphaMessage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AppV1alphaMessage
    {
        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("appUid")]
        public string? AppUid { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("conversationUid")]
        public string? ConversationUid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Content { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::G.JsonConverters.MessageTypeJsonConverter))]
        public global::G.MessageType Type { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("createTime")]
        public global::System.DateTime? CreateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updateTime")]
        public global::System.DateTime? UpdateTime { get; set; }

        /// <summary>
        /// Included only in responses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("msgSenderUid")]
        public string? MsgSenderUid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AppV1alphaMessage" /> class.
        /// </summary>
        /// <param name="uid">
        /// Included only in responses
        /// </param>
        /// <param name="appUid">
        /// Included only in responses
        /// </param>
        /// <param name="conversationUid">
        /// Included only in responses
        /// </param>
        /// <param name="content"></param>
        /// <param name="role"></param>
        /// <param name="type"></param>
        /// <param name="createTime">
        /// Included only in responses
        /// </param>
        /// <param name="updateTime">
        /// Included only in responses
        /// </param>
        /// <param name="msgSenderUid">
        /// Included only in responses
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AppV1alphaMessage(
            string content,
            string role,
            string? uid,
            string? appUid,
            string? conversationUid,
            global::G.MessageType type,
            global::System.DateTime? createTime,
            global::System.DateTime? updateTime,
            string? msgSenderUid)
        {
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Uid = uid;
            this.AppUid = appUid;
            this.ConversationUid = conversationUid;
            this.Type = type;
            this.CreateTime = createTime;
            this.UpdateTime = updateTime;
            this.MsgSenderUid = msgSenderUid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AppV1alphaMessage" /> class.
        /// </summary>
        public AppV1alphaMessage()
        {
        }
    }
}