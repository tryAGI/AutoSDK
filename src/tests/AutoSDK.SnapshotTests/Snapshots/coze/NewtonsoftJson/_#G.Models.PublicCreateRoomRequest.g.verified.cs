//HintName: G.Models.PublicCreateRoomRequest.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PublicCreateRoomRequest
    {
        /// <summary>
        /// 必选参数，Bot id
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; } = default!;

        /// <summary>
        /// 可选参数，room 的配置
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("config")]
        public global::G.PropertiesConfig? Config { get; set; }

        /// <summary>
        /// 可选参数， conversation_id，不传会默认创建一个，见【创建会话】接口
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("conversation_id")]
        public string? ConversationId { get; set; }

        /// <summary>
        /// 可选参数，标识当前与智能体的用户，由使用方自行定义、生成与维护。uid 用于标识对话中的不同用户，不同的 uid，其对话的数据库等对话记忆数据互相隔离。如果不需要用户数据隔离，可以不传此参数。
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("uid")]
        public string? Uid { get; set; }

        /// <summary>
        /// 可选参数，音色 id，不传默认为 xxxy音色
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("voice_id")]
        public string? VoiceId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateRoomRequest" /> class.
        /// </summary>
        /// <param name="botId">
        /// 必选参数，Bot id
        /// </param>
        /// <param name="config">
        /// 可选参数，room 的配置
        /// </param>
        /// <param name="conversationId">
        /// 可选参数， conversation_id，不传会默认创建一个，见【创建会话】接口
        /// </param>
        /// <param name="uid">
        /// 可选参数，标识当前与智能体的用户，由使用方自行定义、生成与维护。uid 用于标识对话中的不同用户，不同的 uid，其对话的数据库等对话记忆数据互相隔离。如果不需要用户数据隔离，可以不传此参数。
        /// </param>
        /// <param name="voiceId">
        /// 可选参数，音色 id，不传默认为 xxxy音色
        /// </param>
        public PublicCreateRoomRequest(
            string botId,
            global::G.PropertiesConfig? config,
            string? conversationId,
            string? uid,
            string? voiceId)
        {
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.Config = config;
            this.ConversationId = conversationId;
            this.Uid = uid;
            this.VoiceId = voiceId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateRoomRequest" /> class.
        /// </summary>
        public PublicCreateRoomRequest()
        {
        }
    }
}