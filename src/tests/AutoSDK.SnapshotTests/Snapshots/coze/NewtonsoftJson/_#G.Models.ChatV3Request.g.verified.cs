//HintName: G.Models.ChatV3Request.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChatV3Request
    {
        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("additional_messages")]
        public global::System.Collections.Generic.IList<global::G.EnterMessage2>? AdditionalMessages { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("auto_save_history")]
        public bool? AutoSaveHistory { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string BotId { get; set; } = default!;

        /// <summary>
        /// 指定 bot 版本；不传取最新版本；publish_status=unpublished_draft 时此参数无效
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("bot_version")]
        public string? BotVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("custom_variables")]
        public global::System.Collections.Generic.Dictionary<string, string>? CustomVariables { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("enable_card")]
        public bool? EnableCard { get; set; }

        /// <summary>
        /// 透传参数到 plugin/workflow 等下游
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("extra_params")]
        public global::System.Collections.Generic.Dictionary<string, string>? ExtraParams { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("meta_data")]
        public global::System.Collections.Generic.Dictionary<string, string>? MetaData { get; set; }

        /// <summary>
        /// key=参数名 value=值 传递给 workflows parameters 参数
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// 发布状态：published_online / unpublished_draft。默认 published_online；不传等同 published_online
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("publish_status")]
        [global::Newtonsoft.Json.JsonConverter(typeof(global::G.JsonConverters.ChatV3RequestPublishStatusJsonConverter))]
        public global::G.ChatV3RequestPublishStatus? PublishStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("shortcut_command")]
        public global::G.ShortcutCommandDetail? ShortcutCommand { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("stream")]
        public bool? Stream { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::Newtonsoft.Json.JsonProperty("user_id", Required = global::Newtonsoft.Json.Required.Always)]
        public string UserId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::Newtonsoft.Json.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3Request" /> class.
        /// </summary>
        /// <param name="botId"></param>
        /// <param name="userId"></param>
        /// <param name="additionalMessages"></param>
        /// <param name="autoSaveHistory"></param>
        /// <param name="botVersion">
        /// 指定 bot 版本；不传取最新版本；publish_status=unpublished_draft 时此参数无效
        /// </param>
        /// <param name="customVariables"></param>
        /// <param name="enableCard"></param>
        /// <param name="extraParams">
        /// 透传参数到 plugin/workflow 等下游
        /// </param>
        /// <param name="metaData"></param>
        /// <param name="parameters">
        /// key=参数名 value=值 传递给 workflows parameters 参数
        /// </param>
        /// <param name="publishStatus">
        /// 发布状态：published_online / unpublished_draft。默认 published_online；不传等同 published_online
        /// </param>
        /// <param name="shortcutCommand"></param>
        /// <param name="stream"></param>
        public ChatV3Request(
            string botId,
            string userId,
            global::System.Collections.Generic.IList<global::G.EnterMessage2>? additionalMessages,
            bool? autoSaveHistory,
            string? botVersion,
            global::System.Collections.Generic.Dictionary<string, string>? customVariables,
            bool? enableCard,
            global::System.Collections.Generic.Dictionary<string, string>? extraParams,
            global::System.Collections.Generic.Dictionary<string, string>? metaData,
            object? parameters,
            global::G.ChatV3RequestPublishStatus? publishStatus,
            global::G.ShortcutCommandDetail? shortcutCommand,
            bool? stream)
        {
            this.AdditionalMessages = additionalMessages;
            this.AutoSaveHistory = autoSaveHistory;
            this.BotId = botId ?? throw new global::System.ArgumentNullException(nameof(botId));
            this.BotVersion = botVersion;
            this.CustomVariables = customVariables;
            this.EnableCard = enableCard;
            this.ExtraParams = extraParams;
            this.MetaData = metaData;
            this.Parameters = parameters;
            this.PublishStatus = publishStatus;
            this.ShortcutCommand = shortcutCommand;
            this.Stream = stream;
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatV3Request" /> class.
        /// </summary>
        public ChatV3Request()
        {
        }
    }
}